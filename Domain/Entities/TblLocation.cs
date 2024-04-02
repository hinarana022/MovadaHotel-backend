using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblLocation
    {
        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        public string? Narration { get; set; }
    }
}
