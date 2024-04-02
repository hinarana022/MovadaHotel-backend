using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class RptviewSaleDeliveryOrderDetail
    {
        public string? SalesInvoiceId { get; set; }
        public string SaleDomasterId { get; set; } = null!;
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal DeliveryUomid { get; set; }
        public decimal? Qty { get; set; }
        public string? DeliveryUomname { get; set; }
        public string? Barcode { get; set; }
        public decimal? DeliveredQty { get; set; }
        public decimal? ProductUomid { get; set; }
        public string? ProductUomname { get; set; }
        public decimal? ProductUomgroupId { get; set; }
        public string? ProductUomgroupName { get; set; }
        public decimal Perctn { get; set; }
        public decimal InvoiceQty { get; set; }
    }
}
