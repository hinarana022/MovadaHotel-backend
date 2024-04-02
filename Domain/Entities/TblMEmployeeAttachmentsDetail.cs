using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeAttachmentsDetail
    {
        public decimal AttachmentsDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string? Type { get; set; }
        public string? IssuedBy { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? Details { get; set; }
    }
}
