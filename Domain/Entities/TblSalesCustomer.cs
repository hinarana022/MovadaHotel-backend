using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalesCustomer
    {
        public decimal SaleInvoiceId { get; set; }
        public decimal? LedgerId { get; set; }
        public string? LedgerName { get; set; }
        public string? Number1 { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
    }
}
