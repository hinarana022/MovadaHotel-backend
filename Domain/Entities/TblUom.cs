using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblUom
    {
        public decimal Uomid { get; set; }
        public string? Uomname { get; set; }
        public string? Narration { get; set; }
        public string? PrintName { get; set; }
    }
}
