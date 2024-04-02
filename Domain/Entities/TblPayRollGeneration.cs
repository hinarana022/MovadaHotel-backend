using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPayRollGeneration
    {
        public decimal PayRollGenerationId { get; set; }
        public string PayRollGenerationNo { get; set; } = null!;
        public string PayRollGenerationType { get; set; } = null!;
        public string PayRollGenerationStatus { get; set; } = null!;
        public string DepartmentId { get; set; } = null!;
        public DateTime DocumentDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
