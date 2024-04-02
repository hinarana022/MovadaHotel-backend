using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblFloor
    {
        public decimal FloorId { get; set; }
        public string? FloorName { get; set; }
        public string? Narration { get; set; }
        public bool? Isactive { get; set; }
    }
}
