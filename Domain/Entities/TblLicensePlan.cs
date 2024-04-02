using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblLicensePlan
    {
        public int Id { get; set; }
        public string PlanName { get; set; } = null!;
        public string PlanType { get; set; } = null!;
        public int NoCount { get; set; }
        public string Application { get; set; } = null!;
    }
}
