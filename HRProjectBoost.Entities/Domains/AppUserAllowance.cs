using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProjectBoost.Entities.Domains
{
    public class AppUserAllowance
    {
        public int AppUserAllowanceID { get; set; }

        public int AppUserID { get; set; }
        public virtual AppUser? AppUser { get; set; }

        public int AllowanceID { get; set; }
        public virtual Allowance? Allowance { get; set; }
    }
}
