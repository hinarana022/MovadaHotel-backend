using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplicationDetail
    {
        public int DetailId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Status { get; set; }
    }
}
