using AutoMapper;
using HRProjectBoost.Business.FluentValidations;
using HRProjectBoost.DataAccess.Context;
using HRProjectBoost.DTOs.DTOs.Manager;
using HRProjectBoost.DTOs.DTOs.Personnel;
using HRProjectBoost.Entities.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;

namespace HRProjectBoost.UI.Areas.Personnel.Controllers
{
    [AllowAnonymous]
    public class PersonnelController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly HRProjectContext _context;
        private readonly IMapper _mapper;

        public PersonnelController(UserManager<AppUser> userManager, HRProjectContext context, IMapper mapper, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var datas = await _userManager.FindByNameAsync(this.User.Identity.Name);
            TempData["company"] = datas.CompanyInfo;
            return View(_mapper.Map<PersonnelDto>(datas));
        }

        [HttpGet]
        public async Task<IActionResult> Details(PersonnelDetailsDto dto)
        {
            var datas = await _userManager.FindByNameAsync(this.User.Identity.Name);
            return View(_mapper.Map<PersonnelDetailsDto>(datas));
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var datas = await _userManager.FindByNameAsync(this.User.Identity.Name);
            return View(_mapper.Map<PersonnelUpdateDto>(datas));
        }

        [HttpPost]
        public async Task<object> Update(PersonnelUpdateDto dto)
        {
            var user = await _userManager.FindByNameAsync(this.User.Identity.Name);
            var UpdateValidator = new PersonnelUpdateDtoValidator();
            var validatorResult = UpdateValidator.Validate(dto);
            if (ModelState.IsValid && validatorResult.IsValid)
            {
                var files = Request.Form.Files;

                if (files.Count != 0)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        files[0].CopyTo(memoryStream);
                        user.ProfilePicture = memoryStream.ToArray();
                    }
                }

                user.Address = dto.Address;
                user.PhoneNumber = dto.PhoneNumber;

                var result = await _userManager.UpdateAsync(user);
                _context.SaveChanges();

                if (result.Succeeded)
                    return RedirectToAction("Index", "Manager");
                else
                    foreach (var item in result.Errors)
                        ModelState.AddModelError("", item.Description);
            }
            else
            {
                //ModelState.AddModelError("", "Hatalar oluştu.");

                string errorMessage = string.Join(", ", validatorResult.Errors.Select(error => error.ErrorMessage));
                ViewBag.ErrorMessage = errorMessage; // Hata alabiliyoruz ancak msji ekrana veremedik henuz viewbag yerine Toastr kurulacak...
                return RedirectToAction("Update", dto);
            }

            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(PersonnelChangePasswordDto changePasswordDto)
        {
            var user = await _userManager.FindByEmailAsync(changePasswordDto.Email);
            if (user is not null)
            {
                var result = await _userManager.ChangePasswordAsync(user, changePasswordDto.CurrentPassword, changePasswordDto.NewPassword);
                if (result.Succeeded)
                {
                    await _signInManager.SignOutAsync();
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
                ModelState.AddModelError("", "User cannot be found");

            return View(user);
        }
    }
}
