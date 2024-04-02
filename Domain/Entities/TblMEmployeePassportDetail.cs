using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeePassportDetail
    {
        public decimal PassportDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string PassportNumber { get; set; } = null!;
        public string CountryOfIssue { get; set; } = null!;
        public DateTime PassportExpiryDate { get; set; }
        public string? VisaNumber { get; set; }
        public DateTime? VisaExpiryDate { get; set; }
    }
}
