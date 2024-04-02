using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSystemDepartment
    {
        public decimal SystemDepartmentId { get; set; }
        public decimal? EmployeeCategoryId { get; set; }
        public decimal? LedgerId { get; set; }
        public decimal? EmployeeId { get; set; }
        public string? DepartmentName { get; set; }
        public string? Narration { get; set; }
    }
}
