using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblStockReturnMaster
    {
        public string StockReturnId { get; set; } = null!;
        public string? StockReturnNo { get; set; }
        public decimal? SupplierId { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? BalanceDue { get; set; }
        public string? StockReturnNarration { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
    }
}
