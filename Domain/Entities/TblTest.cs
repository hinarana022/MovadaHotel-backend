using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblTest
    {
        public int TestId { get; set; }
        public string? TestType { get; set; }
        public string? Under { get; set; }
        public string? TestName { get; set; }
        public decimal? Price { get; set; }
        public string? Unit { get; set; }
        public string? ReportDays { get; set; }
        public string? Description { get; set; }
        public string? Report { get; set; }
        public bool? ChkRange { get; set; }
        public bool? ShowinTest { get; set; }
    }
}
