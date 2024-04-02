using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBarcodeSetting
    {
        public int BarcodeId { get; set; }
        public string? ApplyOn { get; set; }
        public string? ShowProductName { get; set; }
        public string? ShowProductCode { get; set; }
        public bool? ShowMrp { get; set; }
        public bool? ShowCompanyAs { get; set; }
        public bool? ShowPurchaseRateAs { get; set; }
    }
}
