using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPurchaseReturnBillTax
    {
        public decimal PurchaseReturnBillTaxId { get; set; }
        public decimal PurchaseReturnMasterId { get; set; }
        public decimal? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public DateTime? ExtraDate { get; set; }
    }
}
