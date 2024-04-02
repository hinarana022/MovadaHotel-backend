using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEmailComposeAttachment
    {
        public string SentTo { get; set; } = null!;
        public string? Attachment { get; set; }
        public string? Id { get; set; }
    }
}
