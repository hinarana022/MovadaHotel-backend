using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomerAttendance
    {
        public decimal AttendanceId { get; set; }
        public decimal LedgerId { get; set; }
        public bool? IsPresent { get; set; }
        public DateTime AttendanceDate { get; set; }
        public DateTime InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public decimal Seconds { get; set; }
        public decimal Minutes { get; set; }
        public decimal Hours { get; set; }
    }
}
