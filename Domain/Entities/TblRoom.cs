using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoom
    {
        public decimal RoomId { get; set; }
        public string RoomName { get; set; } = null!;
        public int? RoomTypeId { get; set; }
        public int? FloorId { get; set; }
        public string? ExtensioNo { get; set; }
        public bool? Isactive { get; set; }
        public bool IsVirtualRoom { get; set; }
        public int? RoomTop { get; set; }
        public int? RoomLeft { get; set; }
        public int? RoomHeight { get; set; }
        public int? RoomWidth { get; set; }
        public string? Narration { get; set; }
    }
}
