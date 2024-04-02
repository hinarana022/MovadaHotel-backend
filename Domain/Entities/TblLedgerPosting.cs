using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblLedgerPosting
    {
        public decimal LedgerPostingId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public string? VoucherNo { get; set; }
        public decimal? LedgerId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? DetailsId { get; set; }
        public decimal? YearId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? SalesStaffId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
