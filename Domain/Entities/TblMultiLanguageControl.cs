using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMultiLanguageControl
    {
        public decimal FormId { get; set; }
        public string ControlName { get; set; } = null!;
        public string ControlText { get; set; } = null!;
        public string Language { get; set; } = null!;
        public string ControlValue { get; set; } = null!;
        public string FormName { get; set; } = null!;
    }
}
