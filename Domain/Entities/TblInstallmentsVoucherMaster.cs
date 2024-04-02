using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblInstallmentsVoucherMaster
    {
        public decimal InstallmentsVoucherMasterId { get; set; }
        public DateTime? InstallmentsMasterDate { get; set; }
        public string? InstallmentsVoucherNo { get; set; }
        public string? SaleInvoiceId { get; set; }
        public string? SaleInvoiceNo { get; set; }
        public decimal? SalesmanId { get; set; }
        public string? CashBank { get; set; }
        public decimal? VoucherAmount { get; set; }
        public decimal? TotalAmtPaid { get; set; }
        public decimal? TotalReceivableAmt { get; set; }
        public decimal? TotalInstallments { get; set; }
        public decimal? TotalPaidInstallments { get; set; }
        public decimal? TotalReceivableInstallments { get; set; }
        public decimal? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerMobile { get; set; }
    }
}
