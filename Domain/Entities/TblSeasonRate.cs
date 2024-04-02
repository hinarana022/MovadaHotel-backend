using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSeasonRate
    {
        public decimal SeaonRateId { get; set; }
        public string? SeasonRateName { get; set; }
        public int? RoomTypeId { get; set; }
        public int? SeasonId { get; set; }
        public decimal? BaseOccupancy { get; set; }
        public decimal? HigherOccupancy { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? ExtraBedPrice { get; set; }
    }
}
