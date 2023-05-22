using HRProjectBoost.DTOs.DTOs.Authentication;
using HRProjectBoost.Entities.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace HRProjectBoost.UI.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        public UserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto user)
        {

            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByEmailAsync(user.Email);

                if (appUser != null && user.Password == appUser.Password)
                {                   
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.Password, false, lockoutOnFailure: false);
                    if (result.Succeeded)
                        return RedirectToAction("Index", "Manager", new { area = "Manager" });
                }
                else
                {
                    ModelState.AddModelError("", "Yanlış Kullanıcı Adı/Şifre.");                  
                }
                return View(user);
            }
            return View(user);
        }

        [Route("Manager/User/LogoutAsync")]
        public async Task<IActionResult> LogoutAsync()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
