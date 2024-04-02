using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAccountGroup
    {
        public decimal AccountGroupId { get; set; }
        public string? AccountGroupName { get; set; }
        public decimal? GroupUnder { get; set; }
        public string? Nature { get; set; }
        public string? Narration { get; set; }
        public bool? IsDefault { get; set; }
        public string? AffectGrossProfit { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public bool? Status { get; set; }
    }
}
