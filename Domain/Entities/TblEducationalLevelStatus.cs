using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEducationalLevelStatus
    {
        public decimal EducationalLevelStatusId { get; set; }
        public string? EducationalLevelStatus { get; set; }
        public string? Narration { get; set; }
    }
}
