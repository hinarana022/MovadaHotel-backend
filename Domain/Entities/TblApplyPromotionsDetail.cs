using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplyPromotionsDetail
    {
        public decimal ApplyPromotionsDetailsId { get; set; }
        public decimal? ApplyPromotionId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? PromotionPrice { get; set; }
        public bool? Active { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
