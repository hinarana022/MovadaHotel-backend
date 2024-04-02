using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProductBarcode
    {
        public decimal ProductBarcodeId { get; set; }
        public decimal? ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string? Barcode { get; set; }
        public decimal? UomgroupId { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? BaseQty { get; set; }
        public decimal? PurchaseRate { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? PricingLevelId { get; set; }
    }
}
