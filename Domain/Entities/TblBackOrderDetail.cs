using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBackOrderDetail
    {
        public decimal BackOrderDetailsId { get; set; }
        public string BackOrderId { get; set; } = null!;
        public decimal? CustomerId { get; set; }
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? Qty { get; set; }
        public decimal? Uomid { get; set; }
        public string? BackOrderNo { get; set; }
    }
}
