using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSaleDeliveryOrderDetail
    {
        public decimal SaleDodetailsId { get; set; }
        public string SaleDomasterId { get; set; } = null!;
        public string? SalesInvoiceId { get; set; }
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? PurchaseUom { get; set; }
        public decimal? PurchaseQty { get; set; }
        public decimal? PurchaseDiscount { get; set; }
        public decimal? PurchaseBonusQty { get; set; }
        public decimal DeliveryUomid { get; set; }
        public string? DeliveryUomname { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? DeliveredQty { get; set; }
        public decimal? ReturnBonusQty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public string? Narration { get; set; }
        public decimal? RowId { get; set; }
    }
}
