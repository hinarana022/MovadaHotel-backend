using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCashMaster
    {
        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public string ShiftName { get; set; } = null!;
        public int Type { get; set; }
        public int Userid { get; set; }
        public string LastInvoice { get; set; } = null!;
        public string? Machine { get; set; }
        public int? Sessionstatus { get; set; }
        public string? SessionEndingInvoice { get; set; }
        public int? Shiftid { get; set; }
    }
}
