using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAttendanceProductionType
    {
        public decimal AttendanceProductionId { get; set; }
        public string? Name { get; set; }
        public string? AttendanceType { get; set; }
        public string? PeriodType { get; set; }
        public int? WorkUnitId { get; set; }
        public string? Narration { get; set; }
    }
}
