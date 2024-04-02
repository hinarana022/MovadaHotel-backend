using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPurchaseBillTax
    {
        public decimal PurchaseBillTaxId { get; set; }
        public string? InvoiceNo { get; set; }
        public decimal? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
    }
}
