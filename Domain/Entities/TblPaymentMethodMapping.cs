using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPaymentMethodMapping
    {
        public decimal MappingId { get; set; }
        public decimal? PaymentMethodId { get; set; }
        public decimal? LedgerId { get; set; }
        public decimal? BranchId { get; set; }
        public string? MotherboardId { get; set; }
    }
}
