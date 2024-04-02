using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAllowanceEnhancementMaster
    {
        public decimal AllowenceEnhancementId { get; set; }
        public string? AllowanceEnhancementKey { get; set; }
        public string? AllowanceEnhancmentType { get; set; }
        public string? AllowanceOver { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public int? PayScaleId { get; set; }
        public int? EducationLevelId { get; set; }
        public int? EmployeeId { get; set; }
        public string Uid { get; set; } = null!;
    }
}
