using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPurchaseQoutationDetail
    {
        public decimal PurchaseQoutationDetailsId { get; set; }
        public string QoutationId { get; set; } = null!;
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public string? QoutationNo { get; set; }
    }
}
