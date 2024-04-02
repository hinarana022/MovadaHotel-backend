using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPayScale
    {
        public decimal PayScaleId { get; set; }
        public string? PayScaleName { get; set; }
        public string? Narration { get; set; }
    }
}
