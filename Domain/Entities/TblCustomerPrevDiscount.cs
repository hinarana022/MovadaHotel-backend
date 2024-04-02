using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomerPrevDiscount
    {
        public decimal CustomerId { get; set; }
        public string ProductCode { get; set; } = null!;
        public decimal Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? Discount { get; set; }
    }
}
