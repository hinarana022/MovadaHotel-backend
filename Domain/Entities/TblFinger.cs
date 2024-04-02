using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblFinger
    {
        public int Id { get; set; }
        public decimal? LedgerId { get; set; }
        public string? CustomerFinger { get; set; }
    }
}
