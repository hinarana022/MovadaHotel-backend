using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSubCategoryMapping
    {
        public decimal SubCategoryTypeValueId { get; set; }
        public string? CategoryType { get; set; }
        public string? OpdScreenTypeValue { get; set; }
        public string? Value { get; set; }
        public string? SubCategoryType { get; set; }
        public string? SubScreenType { get; set; }
        public string? SubValue { get; set; }
    }
}
