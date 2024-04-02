using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalePriceListDetail
    {
        public decimal SalePriceListId { get; set; }
        public string? PricingLevelId { get; set; }
        public decimal? ProductId { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? SaleRate { get; set; }
    }
}
