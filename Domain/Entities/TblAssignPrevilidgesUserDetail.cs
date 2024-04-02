using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAssignPrevilidgesUserDetail
    {
        public int AssignPrevilidgesUserId { get; set; }
        public string? Permissions { get; set; }
        public bool? Allow { get; set; }
        public bool? Deny { get; set; }
    }
}
