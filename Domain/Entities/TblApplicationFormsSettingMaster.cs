using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplicationFormsSettingMaster
    {
        public string FormName { get; set; } = null!;
        public string ControlName { get; set; } = null!;
        public string? Value { get; set; }
        public bool? DefaultAdd { get; set; }
        public bool? DefaultEdit { get; set; }
    }
}
