using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblContactGroup
    {
        public int ContactGroupId { get; set; }
        public string? ContactGroupName { get; set; }
        public decimal? ContactGroupCode { get; set; }
        public string? GroupDescription { get; set; }
    }
}
