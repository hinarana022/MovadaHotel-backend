using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCategoryOpdmappingValue
    {
        public decimal CategoryTypeValueId { get; set; }
        public string? CategoryType { get; set; }
        public string? OpdScreenTypeValue { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
    }
}
