using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBankAccount
    {
        public decimal AccountId { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? AccountTitle { get; set; }
        public string? Balance { get; set; }
        public int? BankId { get; set; }
        public string? Glaccount { get; set; }
        public bool? StatusStart { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public DateTime? ActiveEnd { get; set; }
        public bool? StatusInactive { get; set; }
        public DateTime? StatusInactivefrom { get; set; }
        public DateTime? StatusInactiveEnd { get; set; }
        public decimal? OpeningBalance { get; set; }
        public string? CrOrDr { get; set; }
    }
}
