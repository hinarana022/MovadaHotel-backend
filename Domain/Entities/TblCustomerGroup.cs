using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomerGroup
    {
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? Descp { get; set; }
    }
}
