using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRateType
    {
        public decimal RateTypeId { get; set; }
        public string RateTypeName { get; set; } = null!;
        public string? PlanType { get; set; }
        public decimal? PlanTypeValue { get; set; }
        public string? Narration { get; set; }
        public bool? Isactive { get; set; }
    }
}
