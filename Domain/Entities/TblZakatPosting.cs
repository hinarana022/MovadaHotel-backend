using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblZakatPosting
    {
        public decimal ZakatPostingId { get; set; }
        public DateTime? DatFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public DateTime? PostingDate { get; set; }
        public string? ZakatPostingNo { get; set; }
        public string TotalStockValue { get; set; } = null!;
        public string? AccountReceivables { get; set; }
        public string? CashInHand { get; set; }
        public string? BankAccountsSum { get; set; }
        public string? Total { get; set; }
        public string? AccountPayables { get; set; }
        public string? TotalWealth { get; set; }
        public string? ZakatCalculation { get; set; }
        public string? Balance { get; set; }
        public string? LedgerId { get; set; }
        public string? Previouszakat { get; set; }
        public decimal? DeductionAcId { get; set; }
    }
}
