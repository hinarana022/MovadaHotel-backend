using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSheduleSm
    {
        public int SheduleSmsId { get; set; }
        public DateTime? SheduleDate { get; set; }
        public TimeSpan? SheduleTime { get; set; }
        public string? Receipient { get; set; }
        public string? ComposeSms { get; set; }
        public string? SelectTemplte { get; set; }
        public string? Smsgroup { get; set; }
        public string? Status { get; set; }
        public string? Send { get; set; }
    }
}
