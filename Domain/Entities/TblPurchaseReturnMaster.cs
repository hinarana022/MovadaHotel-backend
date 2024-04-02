using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPurchaseReturnMaster
    {
        public string PurchaseReturnMasterId { get; set; } = null!;
        public string PurchaseInvoiceId { get; set; } = null!;
        public string? PurchaseInvoiceNo { get; set; }
        public decimal? SupplierId { get; set; }
        public string? SupplierRefNo { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public decimal? CurrencyId { get; set; }
        public DateTime? PurchaseInvoicePostingDate { get; set; }
        public DateTime? PurchaseInvoiceDeliveryDate { get; set; }
        public DateTime? PurchaseInvoiceDocumentDate { get; set; }
        public DateTime? PurchaseReturnDate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountAllowed { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Total { get; set; }
        public string? PurchaseReturnNarration { get; set; }
        public string? PurchaseReturnNo { get; set; }
        public decimal? InvoiceSubtotal { get; set; }
        public decimal? InvoiceDiscount { get; set; }
        public decimal? InvoiceFreight { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public decimal? InvoiceDownPayment { get; set; }
        public decimal? InvoiceBalance { get; set; }
        public decimal? ReturnAmount { get; set; }
        public decimal? BalanceDue { get; set; }
        public decimal? WarehouseId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
