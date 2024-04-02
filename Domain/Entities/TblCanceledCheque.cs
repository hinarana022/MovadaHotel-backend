using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCanceledCheque
    {
        public int ChequeCancelId { get; set; }
        public string? DocNumber { get; set; }
        public string? AccountId { get; set; }
        public string? Status { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public string? ChequeNumber { get; set; }
        public decimal? CancellerId { get; set; }
        public string? Reason { get; set; }
    }
}
