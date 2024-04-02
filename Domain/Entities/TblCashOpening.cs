using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCashOpening
    {
        public int Id { get; set; }
        public decimal Cash { get; set; }
        public string Amount { get; set; } = null!;
        public string Currency { get; set; } = null!;
        public int Value { get; set; }
        public int Masterid { get; set; }
        public int Type { get; set; }
    }
}
