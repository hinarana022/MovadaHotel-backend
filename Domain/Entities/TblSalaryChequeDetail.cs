using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalaryChequeDetail
    {
        public decimal SalarychequeDetailsId { get; set; }
        public decimal? SalarypaymentMasterId { get; set; }
        public decimal? PayeeId { get; set; }
        public string? ChequeNo { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ChequeDate { get; set; }
        public DateTime? ClearanceDate { get; set; }
        public string? Status { get; set; }
        public decimal? IssuerId { get; set; }
        public decimal? AccountId { get; set; }
        public string? ChequeSeries { get; set; }
        public decimal? BankCharges { get; set; }
    }
}
