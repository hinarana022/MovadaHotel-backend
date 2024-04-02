using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ViewAttaBookingReportDatum
    {
        public decimal AttaBookingId { get; set; }
        public decimal? TokenNo { get; set; }
        public string? TokenDate { get; set; }
        public string CustomerMobile { get; set; } = null!;
        public decimal? Weight { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Balance { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Price { get; set; }
        public decimal? AdvanceFlour { get; set; }
        public decimal? DeductFlour { get; set; }
        public string DeductKhout { get; set; } = null!;
        public string IsClean { get; set; } = null!;
        public string Paid { get; set; } = null!;
        public bool? ProductAtta { get; set; }
        public bool? ProductDaal { get; set; }
        public bool? ProductHaldiMirch { get; set; }
    }
}
