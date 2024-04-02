using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSeason
    {
        public decimal SeasonId { get; set; }
        public string? SeasonName { get; set; }
        public int? SeasonTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? IsEndDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Duration { get; set; }
        public string? FromDay { get; set; }
        public string? FromMonth { get; set; }
        public string? ToDay { get; set; }
        public string? ToMonth { get; set; }
        public string? Narration { get; set; }
        public bool? Isactive { get; set; }
    }
}
