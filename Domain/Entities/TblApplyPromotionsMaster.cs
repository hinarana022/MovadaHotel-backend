using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplyPromotionsMaster
    {
        public decimal? ApplyPromotionId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Description { get; set; }
    }
}
