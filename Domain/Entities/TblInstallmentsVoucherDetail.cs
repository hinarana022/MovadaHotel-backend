using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblInstallmentsVoucherDetail
    {
        public decimal InstallmentsVoucherDetailsId { get; set; }
        public string? InstallmentsVoucherNo { get; set; }
        public decimal? InstallmentAmount { get; set; }
        public DateTime? InstallmentDate { get; set; }
        public decimal? CollectedAmount { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public decimal? DiscountAllowed { get; set; }
    }
}
