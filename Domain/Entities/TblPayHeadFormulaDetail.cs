using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPayHeadFormulaDetail
    {
        public int PayHeadFormulaDetailId { get; set; }
        public int PayHeadMasterId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public int? FromAmount { get; set; }
        public int? AmountUpto { get; set; }
        public string SlabType { get; set; } = null!;
        public string ValueBasis { get; set; } = null!;
    }
}
