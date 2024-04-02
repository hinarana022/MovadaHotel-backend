using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSaleQoutationMaster
    {
        public string QoutationId { get; set; } = null!;
        public string? QoutationNo { get; set; }
        public string? CustomerId { get; set; }
        public string? SalesmanId { get; set; }
        public string? PricingLevelId { get; set; }
        public string? CurrencyId { get; set; }
        public string? Status { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountAllowed { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Total { get; set; }
        public string? Narration { get; set; }
        public bool? IsApproved { get; set; }
    }
}
