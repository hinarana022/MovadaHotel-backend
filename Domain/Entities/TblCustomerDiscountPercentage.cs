using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomerDiscountPercentage
    {
        public decimal LedgerId { get; set; }
        public string? DiscountType { get; set; }
        public decimal? Discountvalue { get; set; }
        public string? ValueType { get; set; }
    }
}
