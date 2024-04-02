using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblOpdService
    {
        public decimal ServiceId { get; set; }
        public string ServiceName { get; set; } = null!;
        public decimal ServiceAmount { get; set; }
        public string ServiceNarration { get; set; } = null!;
        public bool? IsConsultant { get; set; }
        public bool? Isactive { get; set; }
    }
}
