using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBikeDocumentReceiving
    {
        public decimal BikeDocumentReceivingId { get; set; }
        public DateTime? ReceivingDate { get; set; }
        public decimal? RegistrationNumberReceivingId { get; set; }
        public string? InvoiceNo { get; set; }
    }
}
