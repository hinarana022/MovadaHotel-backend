using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGroupSm
    {
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? ComposeSms { get; set; }
        public string? SelectTemplate { get; set; }
    }
}
