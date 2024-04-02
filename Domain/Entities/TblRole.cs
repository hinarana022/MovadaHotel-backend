using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRole
    {
        public decimal RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? Narration { get; set; }
    }
}
