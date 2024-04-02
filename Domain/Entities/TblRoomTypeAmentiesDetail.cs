using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoomTypeAmentiesDetail
    {
        public decimal RoomTypeAmentiesId { get; set; }
        public int? RoomTypeId { get; set; }
        public int? AmentiesId { get; set; }
        public bool? MarkAmenties { get; set; }
    }
}
