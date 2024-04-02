using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblNewTicketDetail
    {
        public decimal NewTicketDetailsId { get; set; }
        public decimal? TicketMasterId { get; set; }
        public string? SaleInvoiceId { get; set; }
        public string? SaleInvoiceNo { get; set; }
        public string? ServiceCode { get; set; }
        public string? TicketNo { get; set; }
        public decimal? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? ServiceName { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? TicketAmount { get; set; }
        public decimal? CommisionAmount { get; set; }
        public string? Narration { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? DeliveryTime { get; set; }
        public string? Status { get; set; }
        public decimal? RowId { get; set; }
        public string? Stage { get; set; }
    }
}
