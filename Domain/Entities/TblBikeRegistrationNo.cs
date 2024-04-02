using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBikeRegistrationNo
    {
        public decimal RegistrationNumberReceivingId { get; set; }
        public decimal RegistrationFeeDespositId { get; set; }
        public DateTime? RecevingDate { get; set; }
        public string? RegistrationNo { get; set; }
        public string? InvoiceNo { get; set; }
    }
}
