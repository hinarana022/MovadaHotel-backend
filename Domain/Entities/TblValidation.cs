using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblValidation
    {
        public string FormName { get; set; } = null!;
        public string ControlName { get; set; } = null!;
        public string? DataType { get; set; }
        public string? Color { get; set; }
        public string? Message { get; set; }
        public string? DefaultValue { get; set; }
        public bool? Validated { get; set; }
        public int? MaxmumLength { get; set; }
    }
}
