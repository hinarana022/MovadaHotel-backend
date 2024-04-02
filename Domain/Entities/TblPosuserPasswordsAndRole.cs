using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPosuserPasswordsAndRole
    {
        public decimal EmployeeId { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public decimal? UserRoleId { get; set; }
        public string? Narration { get; set; }
        public bool? Active { get; set; }
        public int? Shiftid { get; set; }
        public bool? ForceShift { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
