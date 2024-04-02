using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblTable
    {
        public decimal Id { get; set; }
        public string? TableName { get; set; }
        public string? AdminId { get; set; }
        public bool? Status { get; set; }
    }
}
