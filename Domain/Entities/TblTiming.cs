using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblTiming
    {
        public decimal TimingId { get; set; }
        public string? TimingType { get; set; }
        public string? TimingBy { get; set; }
        public int? TimingValue { get; set; }
        public string? TimingUnit { get; set; }
        public int? AllowedHolidays { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public int? EmployeeId { get; set; }
        public string? TimingCode { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int? FinancialYear { get; set; }
        public DateTime? ApplicableFrom { get; set; }
        public DateTime? ApplicableTo { get; set; }
    }
}
