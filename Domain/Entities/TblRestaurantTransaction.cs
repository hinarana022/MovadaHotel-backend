using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRestaurantTransaction
    {
        public int RestaurantTransactionsId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Total { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public decimal? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? ActualQty { get; set; }
        public string? Kotstatus { get; set; }
    }
}
