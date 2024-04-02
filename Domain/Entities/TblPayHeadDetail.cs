using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPayHeadDetail
    {
        public decimal PayHeadDetailsId { get; set; }
        public decimal PayHeadMasterId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public decimal PayHeadId { get; set; }
    }
}
