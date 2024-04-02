using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBranding
    {
        public int Id { get; set; }
        public string? BrandingType { get; set; }
        public string BrandingText { get; set; } = null!;
    }
}
