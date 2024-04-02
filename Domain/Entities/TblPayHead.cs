using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPayHead
    {
        public decimal PayHeadId { get; set; }
        public string? PayHeadType { get; set; }
        public decimal? Ledgerid { get; set; }
        public int? AccountGroupId { get; set; }
        public string? PayHeadCode { get; set; }
        public string? PayHeadName { get; set; }
        public string? IncomeType { get; set; }
        public string? Under { get; set; }
        public string? NameInPaySlip { get; set; }
        public string? CalculationType { get; set; }
        public decimal? CalculationValue { get; set; }
        public string? CalculationBasis { get; set; }
        public decimal? AttendanceProductionTypeId { get; set; }
        public decimal? WorkUnitId { get; set; }
        public string? CalculationPeriod { get; set; }
        public string? RoundingMethod { get; set; }
        public decimal? RoundingLimit { get; set; }
        public string? ComputationOn { get; set; }
        public string? StatutoryType { get; set; }
        public bool? SetAlterIncomeTaxDetails { get; set; }
        public bool? AffectNetSalary { get; set; }
        public bool? UseForGratuity { get; set; }
        public bool? IsActive { get; set; }
        public string? Narration { get; set; }
        public bool? IsAllowance { get; set; }
    }
}
