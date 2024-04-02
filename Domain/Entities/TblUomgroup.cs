using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblUomgroup
    {
        public decimal UomgroupId { get; set; }
        public string? UomgroupName { get; set; }
        public string? Narration { get; set; }
    }
}
