using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblForm
    {
        public string FormName { get; set; } = null!;
        public string? FormText { get; set; }
        public string? Shortcode { get; set; }
    }
}
