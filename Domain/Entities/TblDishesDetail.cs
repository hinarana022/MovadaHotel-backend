using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDishesDetail
    {
        public decimal DishDetailsId { get; set; }
        public decimal? DishMasterId { get; set; }
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? Amount { get; set; }
        public bool? Topping { get; set; }
        public string? Calories { get; set; }
    }
}
