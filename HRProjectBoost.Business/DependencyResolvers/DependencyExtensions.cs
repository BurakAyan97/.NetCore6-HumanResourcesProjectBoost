using AutoMapper;
using HRProjectBoost.Business.Mappings.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HRProjectBoost.Business.DependencyResolvers
{
    public static class DependencyExtensions
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
           
            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new ManagerProfile());
                opt.AddProfile(new PersonnelProfile());
                opt.AddProfile(new AuthenticationProfile());
                opt.AddProfile(new AllowanceProfile());
<<<<<<< HEAD
                opt.AddProfile(new AdminProfile());
=======
                opt.AddProfile(new AdvanceProfile());
>>>>>>> a26c394a885546fbe97de44cf20799d9d4b69266
            });


            var mapper = configuration.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
