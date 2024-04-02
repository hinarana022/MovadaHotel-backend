using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPurchaseInvoiceInstallment
    {
        public decimal PurchaseInstallmentsId { get; set; }
        public decimal? PurchaseInvoiceId { get; set; }
        public decimal? Installment { get; set; }
        public DateTime? Date { get; set; }
        public string? Status { get; set; }
    }
}
