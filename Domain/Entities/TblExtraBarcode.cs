using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblExtraBarcode
    {
        public decimal ExtraBarcodeId { get; set; }
        public string? ProductCode { get; set; }
        public string? Barcode { get; set; }
    }
}
