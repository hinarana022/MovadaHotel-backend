using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEattachmentsMaster
    {
        public decimal VoucherAttachmentMasterId { get; set; }
        public DateTime? Attachmentdate { get; set; }
        public string? AttachmentType { get; set; }
        public string? Blno { get; set; }
        public string? TrackingNo { get; set; }
        public string? Pono { get; set; }
        public string? Pino { get; set; }
        public string? ReferenceNo { get; set; }
        public string? Etd { get; set; }
    }
}
