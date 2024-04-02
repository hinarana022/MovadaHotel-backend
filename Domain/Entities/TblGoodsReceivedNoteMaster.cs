using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGoodsReceivedNoteMaster
    {
        public string GrnId { get; set; } = null!;
        public string? GrnNo { get; set; }
        public decimal? SupplierId { get; set; }
        public string? SupplierRefNo { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public decimal? CurrencyId { get; set; }
        public decimal? ShipmentId { get; set; }
        public string? GrnStatus { get; set; }
        public DateTime? GrnPostingDate { get; set; }
        public DateTime? GrnDeliveryDate { get; set; }
        public DateTime? GrnDocumentDate { get; set; }
        public decimal? Totaltax { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountAllowed { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalDownPayment { get; set; }
        public string? GrnNarration { get; set; }
        public decimal? BalanceDue { get; set; }
        public DateTime? Expiry { get; set; }
        public string? Batch { get; set; }
        public bool? ChkBatchOnAll { get; set; }
        public bool? ChkExpiryOnAll { get; set; }
        public string? VendorInvoiceNo { get; set; }
        public string? ShippingAddress { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? WarehouseId { get; set; }
        public string? PurchaseInvoiceId { get; set; }
    }
}
