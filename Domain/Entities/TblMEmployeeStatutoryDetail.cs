using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeStatutoryDetail
    {
        public decimal StatutoryDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string IncomeTaxNumber { get; set; } = null!;
        public string? EpsaccountNumber { get; set; }
        public string? PfaccountNo { get; set; }
        public DateTime? PfdateOfJoining { get; set; }
        public string? Esinumber { get; set; }
        public string? EsidispensaryName { get; set; }
    }
}
