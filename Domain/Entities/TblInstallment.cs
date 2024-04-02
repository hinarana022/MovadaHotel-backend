using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblInstallment
    {
        public decimal InstallmentsId { get; set; }
        public decimal? SalesInvoiceId { get; set; }
        public decimal? Installment { get; set; }
        public DateTime? Date { get; set; }
        public string? Status { get; set; }
    }
}
