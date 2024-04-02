using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblStockDetail
    {
        public decimal StockDetailId { get; set; }
        public decimal? StockMasterId { get; set; }
        public string? ProductBarcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? Qty { get; set; }
        public decimal? WarehouseId { get; set; }
    }
}
