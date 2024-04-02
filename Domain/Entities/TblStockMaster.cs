using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblStockMaster
    {
        public decimal StockMasterId { get; set; }
        public DateTime? Date { get; set; }
        public string? PurchaseInvoiceId { get; set; }
    }
}
