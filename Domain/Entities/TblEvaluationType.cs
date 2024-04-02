using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEvaluationType
    {
        public decimal EvaluationTypeId { get; set; }
        public string? EvaluationTypeName { get; set; }
        public string? Narration { get; set; }
    }
}
