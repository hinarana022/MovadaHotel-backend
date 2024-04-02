using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAttendanceVoucherDetail
    {
        public decimal AttendanceVoucherDetailId { get; set; }
        public int AttendanceVoucherId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TotalMinutes { get; set; }
        public decimal TotalHours { get; set; }
        public decimal TotalHalfDays { get; set; }
        public decimal TotalFullDays { get; set; }
        public decimal ActualDays { get; set; }
        public decimal ApproveDays { get; set; }
    }
}
