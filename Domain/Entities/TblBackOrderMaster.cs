using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBackOrderMaster
    {
        public string BackOrderId { get; set; } = null!;
        public string? BackOrderNo { get; set; }
        public string? SalesmanId { get; set; }
        public string? PricingLevelId { get; set; }
        public string? CurrencyId { get; set; }
        public string? BackOrderStatus { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string? Narration { get; set; }
        public bool? BackOrderisApproved { get; set; }
        public string? Pono { get; set; }
        public string? Pino { get; set; }
        public string? BackOrderPostatus { get; set; }
        public string? BackOrderPistatus { get; set; }
    }
}
