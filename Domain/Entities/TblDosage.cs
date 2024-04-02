using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDosage
    {
        public decimal DosageId { get; set; }
        public string? DosageName { get; set; }
        public string? Narration { get; set; }
        public bool? IsActive { get; set; }
    }
}
