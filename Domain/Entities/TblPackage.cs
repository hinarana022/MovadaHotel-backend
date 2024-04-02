using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPackage
    {
        public decimal PackageId { get; set; }
        public string? PackageName { get; set; }
        public string? ShortName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Duration { get; set; }
        public string? Narration { get; set; }
        public bool? Isactive { get; set; }
    }
}
