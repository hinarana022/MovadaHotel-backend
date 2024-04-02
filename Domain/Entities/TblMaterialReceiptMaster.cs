using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMaterialReceiptMaster
    {
        public string MaterialReceiptMasterId { get; set; } = null!;
        public string? MaterialReceiptNo { get; set; }
        public decimal? SupplierId { get; set; }
        public string? SupplierRefNo { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public decimal? CurrencyId { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalDownPayment { get; set; }
        public string? Narration { get; set; }
        public decimal? WarehouseId { get; set; }
    }
}
