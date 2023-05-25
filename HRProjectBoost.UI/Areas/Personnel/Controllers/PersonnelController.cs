using AutoMapper;
using HRProjectBoost.Business.FluentValidations;
using HRProjectBoost.DataAccess.Context;
using HRProjectBoost.DTOs.DTOs.Allowance;
using HRProjectBoost.DTOs.DTOs.Manager;
using HRProjectBoost.DTOs.DTOs.Personnel;
using HRProjectBoost.Entities.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace HRProjectBoost.UI.Areas.Personnel.Controllers
{
    [AllowAnonymous]
    [Area("Personnel")]
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
            return View(_mapper.Map<PersonnelDTO>(datas));
        }

        [HttpGet]
        public async Task<IActionResult> Details(PersonnelDetailsDTO dto)
        {
            var datas = await _userManager.FindByNameAsync(this.User.Identity.Name);
            return View(_mapper.Map<PersonnelDetailsDTO>(datas));
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var datas = await _userManager.FindByNameAsync(this.User.Identity.Name);
            return View(_mapper.Map<PersonnelUpdateDTO>(datas));
        }

        [HttpPost]
        public async Task<object> Update(PersonnelUpdateDTO dto)
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

        public IActionResult CreateAllowance()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAllowance(AllowanceCreateDto allowanceCreateDto)
        {
            var ext = Path.GetExtension(allowanceCreateDto.AllowanceFile.FileName);
            var path = Directory.GetCurrentDirectory() + "/wwwroot" + "pdfs" + allowanceCreateDto.FileName + ext;

            if (ModelState.IsValid)
            {
                if (allowanceCreateDto.AllowanceFile.ContentType == "image/jpeg" || allowanceCreateDto.AllowanceFile.ContentType == "application/pdf")
                {
                    FileStream stream = new FileStream(path, FileMode.Create);
                    await allowanceCreateDto.AllowanceFile.CopyToAsync(stream);
                }
                else
                    ModelState.AddModelError("", "Wrong Format.Please use only pdf or jpeg.");

                Allowance allowance = new();
                allowance.AllowanceStatus = allowanceCreateDto.AllowanceStatus;
                allowance.AllowanceType = allowanceCreateDto.AllowanceType;
                allowance.CurrencyType = allowanceCreateDto.CurrencyType;
                allowance.AllowanceCreatedTime = allowanceCreateDto.AllowanceCreatedTime;
                allowance.Total = allowanceCreateDto.Total;
                _context.Allowances.Add(allowance);
                await _context.SaveChangesAsync();
            }
            return View(allowanceCreateDto);
        }






    }
}
