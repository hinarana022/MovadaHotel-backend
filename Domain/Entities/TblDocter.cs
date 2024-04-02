using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDocter
    {
        public int? DocterId { get; set; }
        public string? DocterName { get; set; }
        public string? MobileNo { get; set; }
        public string? Address { get; set; }
    }
}
