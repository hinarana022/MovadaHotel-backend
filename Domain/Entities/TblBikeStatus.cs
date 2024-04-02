using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBikeStatus
    {
        public string ChasisNo { get; set; } = null!;
        public string? Status { get; set; }
    }
}
