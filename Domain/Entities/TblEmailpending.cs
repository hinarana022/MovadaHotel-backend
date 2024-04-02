using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEmailpending
    {
        public int? Id { get; set; }
        public string? SentTo { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string? Status { get; set; }
        public string? UserId { get; set; }
        public string? EmailGroup { get; set; }
        public string? Name { get; set; }
    }
}
