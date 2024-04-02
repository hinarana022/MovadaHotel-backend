using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblColor
    {
        public decimal ColorId { get; set; }
        public string? ColorName { get; set; }
        public string? Narration { get; set; }
    }
}
