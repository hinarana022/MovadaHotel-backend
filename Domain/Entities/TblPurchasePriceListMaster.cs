using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPurchasePriceListMaster
    {
        public decimal PurchasePriceListId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public DateTime? ApplicableFrom { get; set; }
    }
}
