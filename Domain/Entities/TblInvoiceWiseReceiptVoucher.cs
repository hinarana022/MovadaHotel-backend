using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblInvoiceWiseReceiptVoucher
    {
        public string? VoucherNo { get; set; }
        public string? InvoiceNo { get; set; }
        public decimal? Amount { get; set; }
    }
}
