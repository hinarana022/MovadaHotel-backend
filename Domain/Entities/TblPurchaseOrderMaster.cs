using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPurchaseOrderMaster
    {
        public string PurchaseOrderId { get; set; } = null!;
        public string? PurchaseOrderNo { get; set; }
        public int? SupplierId { get; set; }
        public int? SalesmanId { get; set; }
        public int? PricingLevelId { get; set; }
        public int? CurrencyId { get; set; }
        public string? SupplierReferenceNo { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? PurchaseOrderstatus { get; set; }
        public bool? PurchaseOrderisApproved { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountAllowed { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Total { get; set; }
        public string? PurchaseOrderNarration { get; set; }
    }
}
