using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblReOrderLevel
    {
        public decimal ReOrderLevelId { get; set; }
        public decimal? ProductId { get; set; }
        public string? UomIdName { get; set; }
        public decimal? UomId { get; set; }
        public decimal? ReOrderLevel { get; set; }
    }
}
