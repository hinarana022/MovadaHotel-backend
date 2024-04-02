using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPurchaseInvoiceImportDetail
    {
        public decimal PurchaseImpInvoiceDetailsId { get; set; }
        public string PurchaseImpInvoiceId { get; set; } = null!;
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RowId { get; set; }
        public decimal? TradePrice { get; set; }
        public decimal? PurchasePricePercent { get; set; }
        public decimal? ProjectId { get; set; }
        public string? InvoicePertainsTo { get; set; }
        public string? InvoiceNo { get; set; }
        public string? BorrowedFromTo { get; set; }
        public string? Paid { get; set; }
        public string? PurchaseOrderNo { get; set; }
        public decimal? Prate { get; set; }
    }
}
