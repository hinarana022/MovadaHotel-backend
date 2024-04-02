using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBank
    {
        public int BankId { get; set; }
        public string BankName { get; set; } = null!;
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
    }
}
