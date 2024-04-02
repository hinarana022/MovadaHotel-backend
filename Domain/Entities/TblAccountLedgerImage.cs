using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAccountLedgerImage
    {
        public decimal? LedgerId { get; set; }
        public byte[]? LedgerPhoto { get; set; }
    }
}
