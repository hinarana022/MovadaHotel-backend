using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPayRollVoucher
    {
        public decimal PayRollVoucherId { get; set; }
        public string PayRollVoucherNo { get; set; } = null!;
        public string PayRollVoucherType { get; set; } = null!;
        public string Employee { get; set; } = null!;
        public DateTime DocumentDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
