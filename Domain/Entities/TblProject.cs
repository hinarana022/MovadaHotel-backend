using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProject
    {
        public decimal ProjectId { get; set; }
        public string? Project { get; set; }
        public string? Narration { get; set; }
        public bool? IsActive { get; set; }
    }
}
