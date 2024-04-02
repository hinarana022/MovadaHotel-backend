using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TableSampleReport
    {
        public string ReportId { get; set; } = null!;
        public byte[] Sample { get; set; } = null!;
    }
}
