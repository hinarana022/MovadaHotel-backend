using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGoodsReceivedNoteAcLedger
    {
        public decimal GrnAcLedgerId { get; set; }
        public string? InvoiceNo { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public decimal? LedgerId { get; set; }
        public string? VoucherNo { get; set; }
        public decimal? VoucherTypeId { get; set; }
    }
}
