using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblHoldWpfPosbillTaxesDatum
    {
        public decimal SaleBillTaxId { get; set; }
        public string? SalesInvoiceNo { get; set; }
        public string? DataTableNo { get; set; }
        public decimal? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
    }
}
