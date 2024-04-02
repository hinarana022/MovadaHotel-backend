using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSaleInstallmentsHistory
    {
        public decimal SaleInvoiceHistoryId { get; set; }
        public decimal? SaleinvoiceInstallmentId { get; set; }
        public string? SaleInvoiceId { get; set; }
        public decimal? InstallmentAmount { get; set; }
        public DateTime? InstallmentDate { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? Status { get; set; }
        public decimal? CollectedAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string? InstallmentsVoucherNo { get; set; }
    }
}
