using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplicationFormsSettingDetail
    {
        public string FormName { get; set; } = null!;
        public string ControlName { get; set; } = null!;
        public string? Operation { get; set; }
        public string? Status { get; set; }
    }
}
