using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblLetterDelivery
    {
        public decimal LetterDeliveryId { get; set; }
        public DateTime? LetterDeliveryDate { get; set; }
        public decimal? LetterId { get; set; }
        public string? ReceivedBy { get; set; }
        public string? Remarks { get; set; }
        public string? InvoiceNo { get; set; }
    }
}
