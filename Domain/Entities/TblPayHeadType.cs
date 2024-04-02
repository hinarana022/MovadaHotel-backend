using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPayHeadType
    {
        public decimal PayHeadTypeId { get; set; }
        public string? PayHeadName { get; set; }
        public string? Narration { get; set; }
        public bool? IsActive { get; set; }
    }
}
