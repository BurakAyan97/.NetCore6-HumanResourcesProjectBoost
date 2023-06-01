
using AutoMapper;
using FluentValidation;
using HRProjectBoost.Business.FluentValidations;
using HRProjectBoost.DataAccess.Context;
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

    }
}