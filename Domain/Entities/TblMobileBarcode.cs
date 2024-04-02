using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMobileBarcode
    {
        public string Barcode { get; set; } = null!;
        public string? Status { get; set; }
    }
}
