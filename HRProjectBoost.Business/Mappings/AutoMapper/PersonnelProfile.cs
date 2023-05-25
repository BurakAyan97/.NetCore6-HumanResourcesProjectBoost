using AutoMapper;
using HRProjectBoost.DTOs.DTOs.Personnel;
using HRProjectBoost.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProjectBoost.Business.Mappings.AutoMapper
{
    public class PersonnelProfile : Profile
    {
        public PersonnelProfile()
        {
            CreateMap<AppUser,PersonnelCreateDto>().ReverseMap();
            CreateMap<AppUser,PersonnelDto>().ReverseMap();
            CreateMap<AppUser,PersonnelUpdateDto>().ReverseMap();
            CreateMap<AppUser,PersonnelDetailsDto>().ReverseMap();

        }
    }
}
