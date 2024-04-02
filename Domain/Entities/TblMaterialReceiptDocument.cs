using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMaterialReceiptDocument
    {
        public decimal MaterialReceiptDocId { get; set; }
        public string? MaterialReceiptMasterId { get; set; }
        public string? Path { get; set; }
        public string? Description { get; set; }
        public byte[]? DataFile { get; set; }
    }
}
