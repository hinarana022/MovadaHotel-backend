using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblWorkUnit
    {
        public decimal WorkUnitId { get; set; }
        public string? WorkUnitType { get; set; }
        public string? WorkUnitSymbol { get; set; }
        public string? FormalName { get; set; }
        public decimal? NoOfDecimalPlaces { get; set; }
        public string? Narration { get; set; }
    }
}
