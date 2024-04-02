using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblStockReturnDetail
    {
        public decimal StockReturnDetailsId { get; set; }
        public string? StockReturnId { get; set; }
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Deduction { get; set; }
        public decimal? Amount { get; set; }
        public string? Narration { get; set; }
        public decimal? RowId { get; set; }
    }
}
