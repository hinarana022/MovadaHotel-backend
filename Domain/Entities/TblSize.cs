using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSize
    {
        public decimal SizeId { get; set; }
        public string? Size { get; set; }
        public string? Narration { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
    }
}
