using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAccountLedgerGaurantor
    {
        public decimal LedgerGaurantorId { get; set; }
        public decimal? LedgerId { get; set; }
        public string? GaurantorName { get; set; }
        public string? GaurantorFatherName { get; set; }
        public string? GaurantorMobile { get; set; }
        public string? GaurantorAddress { get; set; }
    }
}
