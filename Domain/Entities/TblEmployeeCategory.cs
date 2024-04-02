using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEmployeeCategory
    {
        public decimal EmployeeCategoryId { get; set; }
        public string? EmployeeCategoryName { get; set; }
        public bool? AllocateRevenueItems { get; set; }
        public bool? AllocateNonRevenueItems { get; set; }
        public string? Narration { get; set; }
    }
}
