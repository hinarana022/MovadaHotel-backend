using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblHoldWpfPosdatum
    {
        public string? ProductName { get; set; }
        public string? UnitPrice { get; set; }
        public string? Quantity { get; set; }
        public string? Total { get; set; }
        public string? ProductCode { get; set; }
        public int? Uomid { get; set; }
        public string? Uomname { get; set; }
        public string? Barcode { get; set; }
        public DateTime? Date { get; set; }
        public string? Time { get; set; }
        public int? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerMobile { get; set; }
        public string? CustomerAddress { get; set; }
        public string? OrderType { get; set; }
        public string? Kot { get; set; }
        public string? Table { get; set; }
        public string? DataTableNo { get; set; }
        public int? WaiterId { get; set; }
        public string? WaiterName { get; set; }
        public int? RiderId { get; set; }
        public string? RiderName { get; set; }
        public string? TotalDiscount { get; set; }
        public string? SubTotal { get; set; }
        public string? GrandTotal { get; set; }
        public string? Tax { get; set; }
        public string? TaxId { get; set; }
        public string? TaxAmount { get; set; }
        public string? Discount { get; set; }
        public string? OrderStatus { get; set; }
        public string? InvoiceNo { get; set; }
        public int? SalesmanId { get; set; }
        public string? SalesmanName { get; set; }
        public int? CookId { get; set; }
        public string? Kotstatus { get; set; }
        public string? IsKotitem { get; set; }
        public string? Note { get; set; }
        public string? ProductId { get; set; }
        public string? ActualQty { get; set; }
        public string? DealId { get; set; }
    }
}
