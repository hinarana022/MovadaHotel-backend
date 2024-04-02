using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRestaurantTransactionsMaster
    {
        public int RestaurantTransactionsMasterId { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public string? Time { get; set; }
        public decimal? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerMobile { get; set; }
        public string? CustomerAddress { get; set; }
        public string? OrderType { get; set; }
        public decimal? RiderId { get; set; }
        public string? Kot { get; set; }
        public string? Table { get; set; }
        public decimal? WaiterId { get; set; }
        public decimal? CookId { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Freight { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? BalanceDue { get; set; }
        public string? OrderStatus { get; set; }
        public string? Note { get; set; }
    }
}
