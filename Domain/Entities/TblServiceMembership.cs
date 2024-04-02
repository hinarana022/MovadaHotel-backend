using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServiceMembership
    {
        public string ServiceCode { get; set; } = null!;
        public bool? EnableReccurency { get; set; }
        public string? RecurrencesType { get; set; }
    }
}
