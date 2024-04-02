using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAttaBooking
    {
        public decimal AttaBookingId { get; set; }
        public decimal? TokenNo { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Price { get; set; }
        public decimal? AdvanceFlour { get; set; }
        public decimal? DeductFlour { get; set; }
        public bool? IsClean { get; set; }
        public bool? DeductKhout { get; set; }
        public DateTime? TokenDate { get; set; }
        public string? CustomerMobile { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? ProductAtta { get; set; }
        public bool? ProductDaal { get; set; }
        public bool? ProductHaldiMirch { get; set; }
    }
}
