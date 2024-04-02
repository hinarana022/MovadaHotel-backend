using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoomTypeHouseKeepingDetail
    {
        public decimal RoomTypeHouseKeepingId { get; set; }
        public int RoomTypeId { get; set; }
        public string? WeekDayValue { get; set; }
        public bool? MarkWeekDays { get; set; }
    }
}
