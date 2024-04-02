using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblChequesManagment
    {
        public decimal ChequesManagmentId { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public string? VoucherNo { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? TransactionType { get; set; }
        public decimal? BankId { get; set; }
        public decimal? LedgerId { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ChequeDate { get; set; }
        public DateTime? ClearanceDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TransactionCharges { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? Narration { get; set; }
        public string? Status { get; set; }
        public decimal? IssuerId { get; set; }
        public decimal? BankCharges { get; set; }
        public string? AccountId { get; set; }
        public string? ChequeSeries { get; set; }
    }
}
