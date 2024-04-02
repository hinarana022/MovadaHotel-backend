using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblInvestigation
    {
        public decimal PrescriptionId { get; set; }
        public decimal? InvestigationsId { get; set; }
    }
}
