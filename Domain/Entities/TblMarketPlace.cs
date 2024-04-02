using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMarketPlace
    {
        public string MarketPlaceId { get; set; } = null!;
        public string MarketPlaceName { get; set; } = null!;
        public string? Narration { get; set; }
        public bool? Isactive { get; set; }
    }
}
