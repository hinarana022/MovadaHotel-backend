using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblStockAlert
    {
        public decimal? ProductId { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? StockAlterQty { get; set; }
    }
}
