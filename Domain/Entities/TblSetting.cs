using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSetting
    {
        public bool? InvoicePrinting { get; set; }
        public string? NoOfPrints { get; set; }
        public string? PricingSetup { get; set; }
        public bool? ShowKeyboard { get; set; }
        public string? DefaultImagePath { get; set; }
        public string? MacAddress { get; set; }
        public string? OrderReadyTime { get; set; }
        public bool? KotPrint { get; set; }
        public bool? KotPrintOnCheckOut { get; set; }
        public bool? RiderSelectionCompulsory { get; set; }
        public bool? AutoKotreset { get; set; }
        public bool? Kotpreview { get; set; }
        public bool? InvoicePreview { get; set; }
    }
}
