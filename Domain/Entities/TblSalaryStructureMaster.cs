using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalaryStructureMaster
    {
        public decimal SalaryStructureId { get; set; }
        public string SalryCreationType { get; set; } = null!;
        public string EmployeeId { get; set; } = null!;
        public string? Narration { get; set; }
    }
}
