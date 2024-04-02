using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeContractDetail
    {
        public decimal ContractDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string WorkPermitNo { get; set; } = null!;
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
    }
}
