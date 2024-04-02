using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblWpftaxis
    {
        public decimal TaxId { get; set; }
        public string? TaxName { get; set; }
        public string? ApplicableOn { get; set; }
        public decimal? Rate { get; set; }
        public bool? Active { get; set; }
    }
}
