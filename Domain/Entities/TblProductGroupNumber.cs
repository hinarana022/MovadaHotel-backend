using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProductGroupNumber
    {
        public decimal GroupNumberId { get; set; }
        public decimal? GroupId { get; set; }
        public string? Name { get; set; }
        public string? MobNumber { get; set; }
        public bool? AddContactNo { get; set; }
    }
}
