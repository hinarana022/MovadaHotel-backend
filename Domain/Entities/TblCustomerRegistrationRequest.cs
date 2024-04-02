using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomerRegistrationRequest
    {
        public decimal RegistrationRequestId { get; set; }
        public string? RegistrationRequestNo { get; set; }
        public DateTime? RegistrationRequestDate { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal LetterId { get; set; }
        public decimal? Total { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? BalanceDue { get; set; }
        public string? Remarks { get; set; }
        public string? InvoiceNo { get; set; }
    }
}
