using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblOpdRefundDetail
    {
        public decimal RefundDetailsId { get; set; }
        public decimal RefundMasterId { get; set; }
        public decimal OpdTicketDetailsId { get; set; }
        public decimal OpdTicketId { get; set; }
        public decimal ServiceId { get; set; }
        public decimal? ConsultantId { get; set; }
        public decimal ServiceAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
