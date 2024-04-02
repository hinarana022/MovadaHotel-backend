using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeFamilyDetail
    {
        public decimal FamilyDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string? Relation { get; set; }
        public string? Name { get; set; }
        public string? PhoneNo { get; set; }
        public string? MobileNo { get; set; }
    }
}
