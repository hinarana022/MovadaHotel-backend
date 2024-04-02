using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAuhtorityLetterDeliveryAttachment
    {
        public decimal AttachmentId { get; set; }
        public string LetterNo { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
        public string Extenstion { get; set; } = null!;
        public string Path { get; set; } = null!;
        public bool Status { get; set; }
    }
}
