using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoomBookingTimelineDetail
    {
        public decimal TimelineDetailId { get; set; }
        public decimal ReservationId { get; set; }
        public decimal SalesmanId { get; set; }
        public decimal LedgerId { get; set; }
        public decimal YearId { get; set; }
        public DateTime DocumentDate { get; set; }
        public decimal VoucherTypeId { get; set; }
        public string VoucherNo { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
