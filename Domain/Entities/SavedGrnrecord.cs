using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class SavedGrnrecord
    {
        public string PurchaseInvoiceNo { get; set; } = null!;
        public string GrnNo { get; set; } = null!;
        public string? PurchaseInvoiceId { get; set; }
        public string GrnId { get; set; } = null!;
        public decimal GrnDetailsId { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Qtyrceived { get; set; }
    }
}
