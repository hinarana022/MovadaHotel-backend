using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeSalaryStructureDetail
    {
        public decimal SalaryStructureDetailId { get; set; }
        public decimal EmployeeId { get; set; }
        public DateTime EffectedFrom { get; set; }
        public decimal PayHeadId { get; set; }
        public decimal Rate { get; set; }
        public string CalculationBasis { get; set; } = null!;
    }
}
