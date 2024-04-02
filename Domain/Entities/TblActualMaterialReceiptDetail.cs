using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblActualMaterialReceiptDetail
    {
        public decimal MaterialReceiptDetailsId { get; set; }
        public string MaterialReceiptMasterId { get; set; } = null!;
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? GodownId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public string? ReceiptStatus { get; set; }
        public string? ReceiptDate { get; set; }
    }
}
