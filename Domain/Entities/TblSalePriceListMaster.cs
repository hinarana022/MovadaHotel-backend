using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalePriceListMaster
    {
        public decimal SalePriceListId { get; set; }
        public decimal PricingLevelId { get; set; }
        public DateTime ApplicableFrom { get; set; }
    }
}
