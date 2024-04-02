using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBikeDocumentDelivery
    {
        public decimal BikeDocumentDeliveryId { get; set; }
        public decimal BikeDocumentReceivingId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? ReceivedBy { get; set; }
        public string? Remarks { get; set; }
        public string? InvoiceNo { get; set; }
    }
}
