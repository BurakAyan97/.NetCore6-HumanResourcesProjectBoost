using HRProjectBoost.Entities.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProjectBoost.DataAccess.Configurations
{
    public class AppUserAllowanceConfigurations : IEntityTypeConfiguration<AppUserAllowance>
    {
        public void Configure(EntityTypeBuilder<AppUserAllowance> builder)
        {
            builder.HasKey(x => new{ x.AppUserID,x.AllowanceID});

            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUserAllowances).HasForeignKey(x => x.AppUserID);
            builder.HasOne(x => x.Allowance).WithMany(x => x.AppUserAllowances).HasForeignKey(x => x.AllowanceID);
        }
    }
}
