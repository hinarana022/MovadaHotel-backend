using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCity
    {
        public decimal CityId { get; set; }
        public string? CityName { get; set; }
        public string? Narration { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public DateTime? ExtraDate { get; set; }
    }
}
