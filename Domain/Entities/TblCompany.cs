using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCompany
    {
        public decimal CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? MailingName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? EmailId { get; set; }
        public string? Web { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? Tin { get; set; }
        public string? Pan { get; set; }
        public byte[]? Logo { get; set; }
        public DateTime? Tdate { get; set; }
        public string? Pin { get; set; }
        public string? SalesTaxRegistrationNo { get; set; }
        public string? Ntn { get; set; }
    }
}
