using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeExpiredAttachmentsDetail
    {
        public decimal ExpiredAttachmentsDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string? Type { get; set; }
        public string? IssuedBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Details { get; set; }
    }
}
