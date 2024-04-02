using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMultiresult
    {
        public string Caseid { get; set; } = null!;
        public string TestName { get; set; } = null!;
        public string Result { get; set; } = null!;
        public string TestUnit { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Descp { get; set; } = null!;
        public string? Narration { get; set; }
    }
}
