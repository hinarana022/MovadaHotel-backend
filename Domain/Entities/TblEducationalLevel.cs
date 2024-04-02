using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEducationalLevel
    {
        public decimal EducationLevelId { get; set; }
        public string? EducationLevel { get; set; }
        public string? Narration { get; set; }
    }
}
