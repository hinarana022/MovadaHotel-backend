using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class AvailabeGrnqty
    {
        public string? PurchaseInvoiceNo { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal ConsumedByGrn { get; set; }
        public decimal? Balance { get; set; }
    }
}
