using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDepartment
    {
        public decimal DepartmentId { get; set; }
        public string? EmployeeCategoryId { get; set; }
        public string? DepartmentName { get; set; }
        public string? Narration { get; set; }
        public string? Abbrevation { get; set; }
    }
}
