using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCurrencyNote
    {
        public int Id { get; set; }
        public string CurrencyNotes { get; set; } = null!;
        public int? Currencyid { get; set; }
        public bool? IsActive { get; set; }
    }
}
