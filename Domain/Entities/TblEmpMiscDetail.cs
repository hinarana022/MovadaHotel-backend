using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEmpMiscDetail
    {
        public decimal EmpMiscDetailsId { get; set; }
        public string? EmpRegNo { get; set; }
        public string? Type { get; set; }
        public string? Details { get; set; }
    }
}
