using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomReport
    {
        public string CaseId { get; set; } = null!;
        public string? TestName { get; set; }
        public byte[] TestReport { get; set; } = null!;
    }
}
