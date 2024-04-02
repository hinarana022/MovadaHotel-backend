using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCheck
    {
        public decimal? TableId { get; set; }
        public string? Name { get; set; }
        public decimal? CompanyId { get; set; }
    }
}
