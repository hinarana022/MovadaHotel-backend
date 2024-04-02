using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEpurchaseOrderDetail
    {
        public decimal PurchaseOrderDetailsId { get; set; }
        public decimal? PurchaseOrderMasterId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductBarcode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Unit1Id { get; set; }
        public decimal? Unit2Id { get; set; }
        public string? ShipmentDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? Amount { get; set; }
    }
}
