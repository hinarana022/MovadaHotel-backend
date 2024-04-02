using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblTimingDetail
    {
        public decimal TimingDetailId { get; set; }
        public int? TimingId { get; set; }
        public bool? MarkDay { get; set; }
        public string? DayOfWeek { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public int? GraceTimeValue { get; set; }
        public string? GraceTimeType { get; set; }
    }
}
