using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServiceStatus
    {
        public int StatusId { get; set; }
        public string ServiceStatus { get; set; } = null!;
        public string? Narration { get; set; }
    }
}
