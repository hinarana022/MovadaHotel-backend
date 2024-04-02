using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplyPromotionsForBrand
    {
        public decimal PromotionsForBrandId { get; set; }
        public decimal? ApplyPromotionId { get; set; }
        public string? PromotionCode { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal? CashDiscount { get; set; }
    }
}
