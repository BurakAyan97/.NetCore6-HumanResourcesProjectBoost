using HRProjectBoost.DataAccess.Configurations;
using HRProjectBoost.Entities.Domains;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRProjectBoost.DataAccess.Context
{
    public class HRProjectContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public HRProjectContext(DbContextOptions<HRProjectContext> options) : base(options)
        {

        }
        public HRProjectContext()
        {

        }

        public DbSet<Advance> Advances { get; set; }
        public DbSet<Allowance> Allowance { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AppRole>().HasData(
                new AppRole() { Id = 1, Name = "Admin", NormalizedName = "ADMIN", },
                new AppRole() { Id = 2, Name = "Manager", NormalizedName = "MANAGER", },
                new AppRole() { Id = 3, Name = "Personnel", NormalizedName = "PERSONNEL", }
                );

            AppUser user = new AppUser()
            {
                Id = 1,
                UserName = "Admin",
                NormalizedUserName = "Admin".ToUpper(),
                Name = "Admin",
                SecondName = "Admin",
                LastName = "Admin",
                Password = "123456aA-",
                SecondLastName = "Admin",
                PhoneNumber = "12345678901",
                BirthDate = DateTime.Now,
                BirthCity = "Admin",
                IdentityNumber = "12345678998",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                CompanyInfo = "Admin",
                Job = "Admin",
                Department = Entities.Enums.Department.Engineer,
                Address = "İstanbul/Maltepe",
                Salary = 16500,
                Email = "admin.admin@bilgeadamboost.com",
                NormalizedEmail = "admin.admin@bilgeadamboost.com".ToUpper(),
                LockoutEnabled = false,
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            AppUser personelSeed = new AppUser()
            {
                Id = 2,
                UserName = "Burak61",
                NormalizedUserName = "Burak61".ToUpper(),
                Name = "Burak",
                SecondName = "",
                LastName = "Ayan",
                Password = "123456aA-",
                SecondLastName = "",
                PhoneNumber = "905423985612",
                BirthDate = DateTime.Now,
                BirthCity = "Balıkesir",
                IdentityNumber = "41104925332",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                CompanyInfo = "IT",
                Job = "Back End Developer",
                Department = Entities.Enums.Department.Engineer,
                Address = "İstanbul/Maltepe",
                Salary = 16500,
                Email = "burakayan@bilgeadamboost.com",
                NormalizedEmail = "burakayan@bilgeadamboost.com".ToUpper(),
                LockoutEnabled = false,
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            PasswordHasher<AppUser> passwordHasherManager = new PasswordHasher<AppUser>();
            user.PasswordHash = passwordHasherManager.HashPassword(user, "123456aA-");

            PasswordHasher<AppUser> passwordHasherPersonel = new PasswordHasher<AppUser>();
            personelSeed.PasswordHash = passwordHasherPersonel.HashPassword(personelSeed, "123456aA-");

            IdentityUserRole<int> seedManagerRole = new IdentityUserRole<int>() { RoleId = 2, UserId = 1 };
            builder.Entity<IdentityUserRole<int>>().HasData(seedManagerRole);

            IdentityUserRole<int> seedPersonelRole = new IdentityUserRole<int>() { RoleId = 3, UserId = 2 };
            builder.Entity<IdentityUserRole<int>>().HasData(seedPersonelRole);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            var decimalProps = builder.Model
            .GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

            foreach (var property in decimalProps)
            {
                property.SetPrecision(18);
                property.SetScale(2);
            }

            base.OnModelCreating(builder);

        }

    }
}
