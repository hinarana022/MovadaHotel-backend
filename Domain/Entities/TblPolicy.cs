using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPolicy
    {
        public decimal PolicyId { get; set; }
        public string PolicyCode { get; set; } = null!;
        public DateTime TimingMonth { get; set; }
        public DateTime ApplicableFrom { get; set; }
        public DateTime ApplicableTo { get; set; }
        public DateTime DocumentDate { get; set; }
        public int HalfDayValue { get; set; }
        public string HalfDayUnit { get; set; } = null!;
        public int FullDayValue { get; set; }
        public string FullDayUnit { get; set; } = null!;
        public int WeeklyValue { get; set; }
        public string WeeklyUnit { get; set; } = null!;
        public int MonthlyValue { get; set; }
        public string MonthlyUnit { get; set; } = null!;
        public int EmployeeId { get; set; }
    }
}
