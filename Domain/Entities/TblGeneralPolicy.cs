using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGeneralPolicy
    {
        public decimal GeneralPolicyId { get; set; }
        public string GeneralPolicyCode { get; set; } = null!;
        public int DesignationId { get; set; }
        public bool? ExactWeekDays { get; set; }
        public bool? ExactMonthlyDays { get; set; }
        public int HalfDayValue { get; set; }
        public string HalfDayUnit { get; set; } = null!;
        public int FullDayValue { get; set; }
        public string FullDayUnit { get; set; } = null!;
        public int? WeeklyValue { get; set; }
        public string? WeeklyUnit { get; set; }
        public int? MonthlyValue { get; set; }
        public string? MonthlyUnit { get; set; }
        public int PaidLeavesValue { get; set; }
        public string PaidLeavesUnit { get; set; } = null!;
        public int UnPaidLeavesValue { get; set; }
        public string UnPaidLeavesUnit { get; set; } = null!;
        public int PaidAbsentsValue { get; set; }
        public string PaidAbsentsUnit { get; set; } = null!;
        public int UnPaidAbsentsValue { get; set; }
        public string UnPaidAbsentsUnit { get; set; } = null!;
    }
}
