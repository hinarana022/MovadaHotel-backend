using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPrescriptionTest
    {
        public decimal PrescriptionId { get; set; }
        public decimal? TestId { get; set; }
        public bool? SentToLab { get; set; }
    }
}
