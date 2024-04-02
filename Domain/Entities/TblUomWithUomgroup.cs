using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblUomWithUomgroup
    {
        public decimal UomWithUomgroupId { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? UomgroupId { get; set; }
        public string? Narration { get; set; }
    }
}
