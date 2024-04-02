using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDealsMaster
    {
        public decimal DealsMasterId { get; set; }
        public string? DealCode { get; set; }
        public string? DealName { get; set; }
        public string? Description { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? AverageCost { get; set; }
        public decimal? Expenses { get; set; }
        public decimal? TotalDealCost { get; set; }
        public decimal? DealPrice { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxable { get; set; }
        public bool? IsSaleItem { get; set; }
        public bool? IsKotitem { get; set; }
        public string? Barcode { get; set; }
        public decimal? GroupId { get; set; }
    }
}
