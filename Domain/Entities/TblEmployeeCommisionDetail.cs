using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEmployeeCommisionDetail
    {
        public decimal EmployeeCommissionDetailsId { get; set; }
        public decimal? EmployeeCommissionMasterId { get; set; }
        public decimal? EmployeeId { get; set; }
        public decimal? Target { get; set; }
        public decimal? AcheivedAmount { get; set; }
        public string? BonusType { get; set; }
        public decimal? BonusValue { get; set; }
        public decimal? BonusAmount { get; set; }
    }
}
