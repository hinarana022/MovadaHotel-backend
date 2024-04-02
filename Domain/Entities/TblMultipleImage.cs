using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMultipleImage
    {
        public decimal VoucherAttachmentId { get; set; }
        public string? VoucherNo { get; set; }
        public string? FileName { get; set; }
        public string? FileType { get; set; }
        public string? Extenstion { get; set; }
        public string? Path { get; set; }
        public bool? Status { get; set; }
        public decimal? Uomid { get; set; }
        public string? Extra1 { get; set; }
        public decimal? ProductId { get; set; }
    }
}
