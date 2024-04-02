using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoomBookingCancelScheduleDetail
    {
        public decimal ScheduleDetailId { get; set; }
        public decimal ReservationId { get; set; }
        public string ReservationType { get; set; } = null!;
        public decimal ReservationValue { get; set; }
        public string ReservationStatus { get; set; } = null!;
        public string ReservationDate { get; set; } = null!;
        public string ScheduleStartDate { get; set; } = null!;
        public string ScheduleEndDate { get; set; } = null!;
        public DateTime ScheduleDate { get; set; }
        public decimal RoomId { get; set; }
    }
}
