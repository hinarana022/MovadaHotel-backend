using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPosuser
    {
        public decimal EmployeeId { get; set; }
        public string? Cnic { get; set; }
        public string? Name { get; set; }
        public string? FatherName { get; set; }
        public DateTime? Dob { get; set; }
        public string? PhoneNo { get; set; }
        public string? MobileNo { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? BloodGroup { get; set; }
        public string? PresentAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public string? EmpRegNo { get; set; }
        public int? DesignationId { get; set; }
    }
}
