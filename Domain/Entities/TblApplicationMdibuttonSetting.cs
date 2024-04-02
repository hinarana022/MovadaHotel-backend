using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplicationMdibuttonSetting
    {
        public string FormName { get; set; } = null!;
        public string Mdibutton { get; set; } = null!;
        public bool? Status { get; set; }
        public string? Information { get; set; }
        public string? Path { get; set; }
    }
}
