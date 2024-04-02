using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAttaBookingRateSheet
    {
        public int Id { get; set; }
        public decimal? Total { get; set; }
        public decimal? Rate { get; set; }
        public decimal? BalanceAtta { get; set; }
        public decimal? StandardValue { get; set; }
        public bool? Safai { get; set; }
        public bool? Khout { get; set; }
        public bool? ProductAtta { get; set; }
        public bool? ProductDaal { get; set; }
        public bool? ProductHaldiMirch { get; set; }
    }
}
