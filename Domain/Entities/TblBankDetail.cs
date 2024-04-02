using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBankDetail
    {
        public string? EmpRegNo { get; set; }
        public string? BankName { get; set; }
        public string? AccountNo { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
        public string? Comments { get; set; }
    }
}
