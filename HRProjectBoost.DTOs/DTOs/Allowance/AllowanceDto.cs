using HRProjectBoost.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProjectBoost.DTOs.DTOs.Allowance
{
    public class AllowanceDto
    {
        public int Id { get; set; }
        public AllowanceType AllowanceType { get; set; }
        public int Total { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public AllowanceStatus AllowanceStatus { get; set; } = AllowanceStatus.Waiting;
        public DateTime AllowanceCreatedTime { get; set; } = DateTime.Now;
        public DateTime AllowanceAnswerTime { get; set; } = DateTime.Now;
        public byte[]? AllowanceFile { get; set; }
    }
}
