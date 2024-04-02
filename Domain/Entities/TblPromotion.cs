using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPromotion
    {
        public decimal PromotionId { get; set; }
        public string? PromotionName { get; set; }
        public string? PromotionDetails { get; set; }
        public bool? IsActive { get; set; }
    }
}
