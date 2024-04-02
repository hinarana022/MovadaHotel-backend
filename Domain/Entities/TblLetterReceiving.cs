using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblLetterReceiving
    {
        public decimal LetterId { get; set; }
        public DateTime? LetterReceivingDate { get; set; }
        public string? LetterNo { get; set; }
        public string? ChasisNo { get; set; }
        public string? InvoiceNo { get; set; }
    }
}
