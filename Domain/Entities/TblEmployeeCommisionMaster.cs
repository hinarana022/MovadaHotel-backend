using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEmployeeCommisionMaster
    {
        public decimal EmployeeCommissionMasterId { get; set; }
        public string? EmployeeCommissionNo { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
