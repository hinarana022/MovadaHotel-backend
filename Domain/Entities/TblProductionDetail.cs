using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProductionDetail
    {
        public decimal ProductionDetailsId { get; set; }
        public decimal? ProductionMasterId { get; set; }
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
    }
}
