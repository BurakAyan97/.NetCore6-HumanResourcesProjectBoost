using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRProjectBoost.Entities.Interfaces;

namespace HRProjectBoost.Entities.Domains
{
    public abstract class BaseEntity:IBaseEntity
    {
        public int Id { get; set; }
    }
}
