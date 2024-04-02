using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoomImage
    {
        public decimal RoomImageDetailId { get; set; }
        public int RoomId { get; set; }
        public string? FileName { get; set; }
        public string? FileType { get; set; }
        public string? Extension { get; set; }
        public string? FilePath { get; set; }
    }
}
