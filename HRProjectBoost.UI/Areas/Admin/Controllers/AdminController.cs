
using AutoMapper;
using FluentValidation;
using HRProjectBoost.Business.FluentValidations;
using HRProjectBoost.DataAccess.Context;
using HRProjectBoost.DTOs.DTOs.Admin;
using HRProjectBoost.DTOs.DTOs.Allowance;
using HRProjectBoost.DTOs.DTOs.Manager;
using HRProjectBoost.DTOs.DTOs.Personnel;
using HRProjectBoost.Entities.Domains;
using HRProjectBoost.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Net.Mail;

namespace HRProjectBoost.UI.Areas.Manager.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly HRProjectContext _context;
        private readonly IMapper _mapper;

        public AdminController(UserManager<AppUser> userManager, HRProjectContext context, IMapper mapper, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var datas = await _userManager.FindByNameAsync(this.User.Identity.Name);
            TempData["company"] = datas.CompanyInfo;
            return View(_mapper.Map<ManagerDto>(datas));
        }

        [HttpGet]
        public async Task<IActionResult> CreateCompany()
        {



            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(CompanyCreateDto dto)
        {
            Company createdCompany = _mapper.Map<Company>(dto);


            var files = Request.Form.Files;
            if (files.Count != 0)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    files[0].CopyTo(memoryStream);
                    createdCompany.Logo = memoryStream.ToArray();
                }
            }


            createdCompany.AgreementStartDate = DateTime.Now;
            createdCompany.AgreementEndDate = createdCompany.AgreementStartDate.AddYears(2);
            createdCompany.CompanyEmail = "support@" + createdCompany.CompanyName.Trim().ToLower() + ".com";
            createdCompany.CompanyStatus = Entities.Enums.CompanyStatus.Active;


            _context.Company.Add(createdCompany);
            await _context.SaveChangesAsync();

            return RedirectToAction("ListCompaniesAndManagers");

        }

        [HttpGet]
        public async Task<IActionResult> ListCompaniesAndManagers()
        {
            var company = _context.Company.Include(x => x.AppUser).ToList();

            List<CompanyDto> dto = _mapper.Map<List<CompanyDto>>(company);

            foreach (var item in dto)
            {
                if (item.AppUser != null)
                {
                    foreach (var manager in item.AppUser)
                    {
                        var IsManager = await _userManager.IsInRoleAsync(manager, "Manager");
                        if (IsManager)
                        {
                            item.Managers.Add(manager);
                        }
                    }
                }
            }
            return View(dto);
        }


        [HttpGet]
        public async Task<IActionResult> AddManager(string MersisNo)
        {
            Company company = _context.Company.FirstOrDefault(x => x.MersisNo == MersisNo);

            ManagerCreateDto dto = new ManagerCreateDto()
            {
                CompanyId = company.CompanyId
            };

            return View(dto);

        }

        [HttpPost]
        public async Task<IActionResult> AddManager(ManagerCreateDto manager)
        {
            AppUser newManager = _mapper.Map<AppUser>(manager);

            var password = GenerateRandomPassword();

            Company company = await _context.Company.FindAsync(manager.CompanyId);
            newManager.Company= company;
            newManager.CompanyInfo = company.CompanyName;

            var result = await _userManager.CreateAsync(newManager, password);

            _context.SaveChanges();

            await _userManager.AddToRoleAsync(newManager, "Manager");



            return RedirectToAction("ListCompaniesAndManagers");

        }






        public string GenerateRandomPassword(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var password = new string(Enumerable.Repeat(chars, length)
                                                .Select(s => s[random.Next(s.Length)])
                                                .ToArray());
            return password;
        }



    }

}
