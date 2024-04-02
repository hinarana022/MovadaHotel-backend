using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalePriceListDetailsLog
    {
        public decimal? SalePriceListId { get; set; }
        public string? PricingLevelId { get; set; }
        public decimal? ProductId { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? SaleRate { get; set; }
        public string? UpdaterEmployeeId { get; set; }
        public string? UpdaterEmployeeName { get; set; }
        public string? UpdaterDate { get; set; }
        public string? UpdaterTime { get; set; }
    }
}
