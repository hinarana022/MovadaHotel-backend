using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDealsDetail
    {
        public decimal DealsDetailsId { get; set; }
        public decimal? DealsMasterId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
    }
}
