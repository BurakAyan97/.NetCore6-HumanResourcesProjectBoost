using AutoMapper;
using HRProjectBoost.DataAccess.Context;
using HRProjectBoost.DTOs.DTOs.Personnel;
using HRProjectBoost.Entities.Domains;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HRProjectBoost.UI.Areas.Personnel.Controllers
{
    [Area("Personnel")]
    public class PersonnelController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly HRProjectContext _context;
        private readonly IMapper _mapper;

        public PersonnelController(UserManager<AppUser> userManager, HRProjectContext context, IMapper mapper)
        {
            _userManager = userManager;    
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("Manager/Personel/PersonelDetails/{Email?}")]
        public async Task<ActionResult> PersonelDetails(string Email)
        {
            var user = await _userManager.FindByEmailAsync(Email);
            var dto = _mapper.Map<PersonnelDetailsDTO>(user);
            return View("PersonnelDetails",dto);
        }


    }
}
