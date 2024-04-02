using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCompanyIncentiveDetail
    {
        public decimal CompanyIncentiveDetailsId { get; set; }
        public decimal? CompanyIncentiveMasterId { get; set; }
        public string? PurchaseInvoiceNo { get; set; }
        public string? UomgroupName { get; set; }
        public string? BrandName { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public string? GroupName { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalIncentive { get; set; }
        public decimal? MasterId { get; set; }
    }
}
