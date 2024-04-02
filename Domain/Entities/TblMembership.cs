using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMembership
    {
        public decimal MembershipId { get; set; }
        public decimal? LedgerId { get; set; }
        public decimal? SalesInvoiceId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? ServiceCode { get; set; }
        public DateTime? RecurrenceStartDate { get; set; }
        public DateTime? NextInvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? Active { get; set; }
        public decimal? RowId { get; set; }
        public string? MembershipStatus { get; set; }
    }
}
