using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSeasonType
    {
        public decimal SeasonTypeId { get; set; }
        public string? SeasonTypeName { get; set; }
        public string? Narration { get; set; }
        public bool? Isactive { get; set; }
    }
}
