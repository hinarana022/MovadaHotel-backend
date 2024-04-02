using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEmpMiscDetailsType
    {
        public decimal MiscDetailsTypeId { get; set; }
        public string? MiscDetailsType { get; set; }
        public string? AttachmentType { get; set; }
        public string? Narration { get; set; }
    }
}
