using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeDocumentsDetail
    {
        public decimal DocumentDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string? FileName { get; set; }
        public string? Narration { get; set; }
        public string? FileType { get; set; }
        public string? Extension { get; set; }
        public string? FilePath { get; set; }
    }
}
