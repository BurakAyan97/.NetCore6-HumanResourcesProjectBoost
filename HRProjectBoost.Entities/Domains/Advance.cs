using HRProjectBoost.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProjectBoost.Entities.Domains
{
    public class Advance
    {
        public int AdvanceId { get; set; }
        public int Total { get; set; }
        public string Description { get; set; }
        public AdvanceType AdvanceType { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public Status AdvanceStatus { get; set; }



        //Nav Props
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }

        
    }
}
