using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeExperienceDetail
    {
        public decimal ExperienceDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string? Details { get; set; }
        public string? Role { get; set; }
        public string? Pay { get; set; }
        public string? JobStatus { get; set; }
        public DateTime? JobFrom { get; set; }
        public DateTime? JobTo { get; set; }
    }
}
