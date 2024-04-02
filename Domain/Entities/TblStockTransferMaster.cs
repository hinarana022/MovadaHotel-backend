using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblStockTransferMaster
    {
        public string StockTransferMasterId { get; set; } = null!;
        public string? StockTransferNo { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public decimal? CurrencyId { get; set; }
        public DateTime? PurchaseDocumentDate { get; set; }
        public decimal? Total { get; set; }
        public string? Narration { get; set; }
        public decimal? FromWarehouseId { get; set; }
        public decimal? ToWarehouseId { get; set; }
    }
}
