using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalesInvoiceDetail
    {
        public decimal SalesInvoiceDetailsId { get; set; }
        public string? SalesInvoiceId { get; set; }
        public string? SalesInvoiceNo { get; set; }
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? Qty { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RowId { get; set; }
        public decimal? ActualUnitCost { get; set; }
        public decimal? PriceInPkr { get; set; }
        public string? Category { get; set; }
        public decimal? TradePrice { get; set; }
        public decimal? SalePricePercent { get; set; }
        public decimal? ProjectId { get; set; }
        public string? InvoicePertainsTo { get; set; }
        public string? InvoiceNo { get; set; }
        public string? BorrowedFromTo { get; set; }
        public string? Paid { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string? DealId { get; set; }
        public decimal? Srate { get; set; }
        public string? HsCode { get; set; }
    }
}
