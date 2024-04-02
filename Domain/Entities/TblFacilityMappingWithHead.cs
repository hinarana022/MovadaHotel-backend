using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblFacilityMappingWithHead
    {
        public decimal FacilityMappingId { get; set; }
        public decimal? FacilityId { get; set; }
        public string? Condition { get; set; }
        public decimal? AllowanceId { get; set; }
        public string? Narration { get; set; }
    }
}
