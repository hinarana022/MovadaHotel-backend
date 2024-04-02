using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAllergy
    {
        public decimal AllergyId { get; set; }
        public string? AllergyName { get; set; }
        public bool? IsActive { get; set; }
        public string? Narration { get; set; }
    }
}
