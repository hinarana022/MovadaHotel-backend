using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblShortPrevilidgeDetail
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public string? FormName { get; set; }
    }
}
