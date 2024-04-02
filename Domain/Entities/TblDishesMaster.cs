using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDishesMaster
    {
        public decimal DishMasterId { get; set; }
        public string? Barcode { get; set; }
        public string DishCode { get; set; } = null!;
        public string? DishName { get; set; }
        public decimal? PricingLevelId { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? GroupId { get; set; }
        public decimal? DishCategoryId { get; set; }
        public string? Guide { get; set; }
        public decimal? IngredientsCost { get; set; }
        public decimal? Expenses { get; set; }
        public decimal? AverageCostPrice { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? SalesmanId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxable { get; set; }
        public bool? IsSaleItem { get; set; }
        public bool? IsKotitem { get; set; }
        public string? Ismultipleunit { get; set; }
        public decimal? UomgroupId { get; set; }
        public decimal? DefaultUomid { get; set; }
    }
}
