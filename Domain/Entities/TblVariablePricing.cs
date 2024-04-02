using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblVariablePricing
    {
        public decimal VariablePricingId { get; set; }
        public decimal? ProductId { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? FromQuantity { get; set; }
        public decimal? ToQuantity { get; set; }
        public decimal? Price { get; set; }
    }
}
