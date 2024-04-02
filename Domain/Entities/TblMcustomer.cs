using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMcustomer
    {
        public decimal CustomerId { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? Narration { get; set; }
        public string? MailingName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public decimal? CreditPeriod { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? PricinglevelId { get; set; }
        public string? BillByBill { get; set; }
        public string? Tin { get; set; }
        public string? Cst { get; set; }
        public string? Pan { get; set; }
        public decimal? RouteId { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
        public decimal? AreaId { get; set; }
    }
}
