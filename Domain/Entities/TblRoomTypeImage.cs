using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoomTypeImage
    {
        public decimal RoomTypeId { get; set; }
        public byte[]? RoomTypeImage { get; set; }
    }
}
