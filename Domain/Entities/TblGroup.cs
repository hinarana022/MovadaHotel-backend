using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGroup
    {
        public decimal GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? Narration { get; set; }
    }
}
