using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblChequeBook
    {
        public decimal Id { get; set; }
        public string DocNumber { get; set; } = null!;
        public decimal AccountId { get; set; }
        public string? Status { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public string? ChequeNumberfrom { get; set; }
        public string? ChequeNumberTo { get; set; }
    }
}
