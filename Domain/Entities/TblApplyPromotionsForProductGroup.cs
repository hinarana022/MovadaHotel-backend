using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplyPromotionsForProductGroup
    {
        public decimal PromotionsForProductGroupId { get; set; }
        public decimal? ApplyPromotionId { get; set; }
        public string? PromotionCode { get; set; }
        public decimal? ProductGroupId { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal? CashDiscount { get; set; }
    }
}
