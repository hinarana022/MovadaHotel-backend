using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoomBookingCancel
    {
        public int CancellationId { get; set; }
        public string? ReservationNo { get; set; }
        public decimal? CancellationFee { get; set; }
        public string? Reason { get; set; }
        public string? Remarks { get; set; }
        public int? CancelledFrom { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledDate { get; set; }
        public bool? ApplyTax { get; set; }
        public decimal? AmountPercentage { get; set; }
    }
}
