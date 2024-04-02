using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDepartmentLedgerMapping
    {
        public decimal MappingId { get; set; }
        public decimal? DepartmentId { get; set; }
        public decimal? LedgerId { get; set; }
    }
}
