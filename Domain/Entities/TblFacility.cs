using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblFacility
    {
        public decimal FacilityId { get; set; }
        public string? FacilityName { get; set; }
        public decimal? WorthInFigures { get; set; }
        public string? Narration { get; set; }
    }
}
