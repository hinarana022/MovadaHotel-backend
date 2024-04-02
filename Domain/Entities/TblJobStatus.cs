using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblJobStatus
    {
        public decimal JobStatusId { get; set; }
        public string? JobStatus { get; set; }
        public string? Narration { get; set; }
    }
}
