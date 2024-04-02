using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDishCategory
    {
        public decimal DishCategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Narration { get; set; }
    }
}
