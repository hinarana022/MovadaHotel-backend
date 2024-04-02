using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblOpdRefundMaster
    {
        public decimal RefundMasterId { get; set; }
        public decimal OpdTicketId { get; set; }
        public string? TicketNo { get; set; }
        public decimal? TokenNo { get; set; }
        public DateTime? Date { get; set; }
        public decimal? PatientId { get; set; }
        public decimal? DoctorId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? CompanyId { get; set; }
        public decimal? PaymentMethodId { get; set; }
        public DateTime? RefundDate { get; set; }
    }
}
