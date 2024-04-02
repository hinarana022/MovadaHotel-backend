using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCompanyIncentiveMaster
    {
        public decimal CompanyIncentiveMasterId { get; set; }
        public string? CompanyIncentiveNo { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? SupplierId { get; set; }
        public decimal? GroupId { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? CashierId { get; set; }
        public decimal? PaymentMethodId { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? UnitIncentive { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Narration { get; set; }
    }
}
