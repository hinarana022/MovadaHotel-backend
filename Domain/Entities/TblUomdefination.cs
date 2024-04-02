using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblUomdefination
    {
        public decimal UomdefinitionId { get; set; }
        public decimal? BaseUomid { get; set; }
        public decimal? BaseQty { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UomgroupId { get; set; }
    }
}
