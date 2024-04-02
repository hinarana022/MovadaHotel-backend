using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSplitBill
    {
        public decimal SplitBillId { get; set; }
        public string? SaleInvoiceNo { get; set; }
        public string? PaymnetMethod { get; set; }
        public decimal? Amount { get; set; }
    }
}
