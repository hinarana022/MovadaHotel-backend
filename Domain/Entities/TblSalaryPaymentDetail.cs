using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalaryPaymentDetail
    {
        public decimal SalarypaymentDetailsId { get; set; }
        public decimal SalarypaymentMasterId { get; set; }
        public decimal? LedgerId { get; set; }
        public decimal? Amount { get; set; }
        public string? ChequeNo { get; set; }
        public string? ChequeDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? Narration { get; set; }
        public decimal? ProjectId { get; set; }
        public string? InvoicePertainsTo { get; set; }
        public string? InvoiceNo { get; set; }
        public string? BorrowedFromTo { get; set; }
        public string? Paid { get; set; }
    }
}
