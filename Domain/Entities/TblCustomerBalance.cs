using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomerBalance
    {
        public decimal TransactionId { get; set; }
        public string? CustomerCode { get; set; }
        public DateTime? Date { get; set; }
        public string? Narration { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
    }
}
