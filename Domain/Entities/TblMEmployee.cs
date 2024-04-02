using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployee
    {
        public decimal EmployeeId { get; set; }
        public string? EmpRegNo { get; set; }
        public string? CardNo { get; set; }
        public string? Cnic { get; set; }
        public string? FirtName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string? PhoneNo { get; set; }
        public string? MobileNo { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? BloodGroup { get; set; }
        public string? PresentAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public string? DepartmentId { get; set; }
        public string? DesignationId { get; set; }
        public string? PayScaleId { get; set; }
        public string? CommissionType { get; set; }
        public decimal? Commission { get; set; }
        public string WageType { get; set; } = null!;
        public string? IncrementType { get; set; }
        public string? IncrementPeriod { get; set; }
        public decimal? IncrementValue { get; set; }
        public string? IncrementBasis { get; set; }
        public decimal? BasisValue { get; set; }
        public decimal? OpeningBalance { get; set; }
        public string? CrOrDr { get; set; }
        public int? Ledgerid { get; set; }
        public string? LedgerCode { get; set; }
        public decimal? SaleTarget { get; set; }
    }
}
