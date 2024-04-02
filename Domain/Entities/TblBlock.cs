using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBlock
    {
        public decimal BlockId { get; set; }
        public string? BlockName { get; set; }
        public string? Narration { get; set; }
        public bool? Isactive { get; set; }
    }
}
