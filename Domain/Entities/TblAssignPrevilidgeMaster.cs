using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAssignPrevilidgeMaster
    {
        public int AssignPrevilidgesId { get; set; }
        public string? Location { get; set; }
        public string? Role { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public string? Remarks { get; set; }
        public bool? Active { get; set; }
        public string? ModuleName { get; set; }
    }
}
