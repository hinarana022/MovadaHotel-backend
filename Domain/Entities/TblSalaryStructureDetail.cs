using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalaryStructureDetail
    {
        public decimal SalaryStructureDetailId { get; set; }
        public int SalaryStructureId { get; set; }
        public DateTime EffectedFrom { get; set; }
        public int PayHeadId { get; set; }
        public int Rate { get; set; }
        public string CalculationBasis { get; set; } = null!;
    }
}
