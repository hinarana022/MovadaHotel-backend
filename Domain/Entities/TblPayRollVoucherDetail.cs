using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPayRollVoucherDetail
    {
        public decimal PayRollVoucherDetailId { get; set; }
        public decimal PayRollVoucherId { get; set; }
        public int PayHeadId { get; set; }
        public decimal TotalAttendance { get; set; }
        public decimal Seconds { get; set; }
        public decimal Minutes { get; set; }
        public decimal Hours { get; set; }
        public decimal Days { get; set; }
        public decimal FinalTotal { get; set; }
    }
}
