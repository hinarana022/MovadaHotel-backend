using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGodownStockDetail
    {
        public int GodownStockDetailsId { get; set; }
        public int? InvoiceDetailsId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ProductCode { get; set; }
        public int? Uomid { get; set; }
        public string? Batch { get; set; }
        public DateTime? Expiry { get; set; }
        public int? VoucherTypeId { get; set; }
    }
}
