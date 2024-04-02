using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblTicketMaster
    {
        public decimal TicketMasterId { get; set; }
        public string? SalesInvoiceId { get; set; }
        public string? Narration { get; set; }
    }
}
