using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSaleOrderMaster
    {
        public string SaleOrderId { get; set; } = null!;
        public string? SaleorderNo { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public decimal? CurrencyId { get; set; }
        public string? SaleOrderStatus { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountAllowed { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Total { get; set; }
        public string? Narration { get; set; }
        public bool? SaleOrderisApproved { get; set; }
    }
}
