using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAttendanceVoucher
    {
        public decimal AttendanceVoucherId { get; set; }
        public string AttendanceVoucherNo { get; set; } = null!;
        public string AttendanceVoucherType { get; set; } = null!;
        public string AttendanceVoucherStatus { get; set; } = null!;
        public string DepartmentId { get; set; } = null!;
        public DateTime DocumentDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
