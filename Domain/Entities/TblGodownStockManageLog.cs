using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGodownStockManageLog
    {
        public string? ProductCode { get; set; }
        public string? GodownId { get; set; }
        public string? Uomid { get; set; }
        public string? Qty { get; set; }
        public string? BatchNo { get; set; }
        public string? Expiry { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public int? UserId { get; set; }
        public string? InvoiceId { get; set; }
        public int? VoucherTypeId { get; set; }
        public string? Remarks { get; set; }
    }
}
