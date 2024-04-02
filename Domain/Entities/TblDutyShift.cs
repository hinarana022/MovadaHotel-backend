using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDutyShift
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; } = null!;
        public TimeSpan ShiftFrom { get; set; }
        public TimeSpan ShiftTo { get; set; }
        public string ShiftNature { get; set; } = null!;
        public string? ShiftStart { get; set; }
        public bool SundayOff { get; set; }
        public string Narration { get; set; } = null!;
    }
}
