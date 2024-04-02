using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeBankDetail
    {
        public decimal BankDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string? BankName { get; set; }
        public string? BankAcNo { get; set; }
        public string? BankSwiftcode { get; set; }
        public string? BankIbanno { get; set; }
        public string? BankBranch { get; set; }
        public string? BankBranchCode { get; set; }
    }
}
