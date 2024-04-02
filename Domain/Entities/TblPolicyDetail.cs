using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPolicyDetail
    {
        public decimal PolicyDetailId { get; set; }
        public decimal PolicyId { get; set; }
        public bool MarkDay { get; set; }
        public string DayOfWeek { get; set; } = null!;
        public TimeSpan TimeIn { get; set; }
        public TimeSpan TimeOut { get; set; }
        public int? InTimeGraceValue { get; set; }
        public string? InTimeGraceType { get; set; }
        public int? OutTimeGraceValue { get; set; }
        public string? OutTimeGraceType { get; set; }
    }
}
