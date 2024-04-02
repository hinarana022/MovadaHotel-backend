using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplyPromotionsWithHappyHour
    {
        public decimal HappyHourTableId { get; set; }
        public decimal ApplyPromotionId { get; set; }
        public string? PromotionCode { get; set; }
        public bool? HappyHour { get; set; }
        public bool? Monday { get; set; }
        public bool? Tuesday { get; set; }
        public bool? Wednesday { get; set; }
        public bool? Thursday { get; set; }
        public bool? Friday { get; set; }
        public bool? Saturday { get; set; }
        public bool? Sunday { get; set; }
        public TimeSpan? Time1From { get; set; }
        public TimeSpan? Time1To { get; set; }
        public TimeSpan? Time2From { get; set; }
        public TimeSpan? Time2To { get; set; }
        public bool? Time1isActive { get; set; }
        public bool? Time2isActive { get; set; }
    }
}
