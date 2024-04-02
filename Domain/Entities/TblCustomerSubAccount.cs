using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomerSubAccount
    {
        public decimal CustomerSubAccountId { get; set; }
        public decimal? AccountGroupId { get; set; }
        public decimal? LedgerId { get; set; }
        public string? Title { get; set; }
        public string? Number { get; set; }
    }
}
