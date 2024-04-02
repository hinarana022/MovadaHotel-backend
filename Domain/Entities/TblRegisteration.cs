using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRegisteration
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? State { get; set; }
        public string? PhoneNo { get; set; }
        public string? MobileNo { get; set; }
        public string EmailId { get; set; } = null!;
        public string? Website { get; set; }
        public string? Tinno { get; set; }
        public string? Panno { get; set; }
        public string? Address { get; set; }
        public string ApplicationId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string LiscenseNo { get; set; } = null!;
        public string LiscenseStatus { get; set; } = null!;
        public string LiscenseType { get; set; } = null!;
        public int NoOfMachines { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string RegisterationKey { get; set; } = null!;
        public string ApplicationKey { get; set; } = null!;
        public int? NoOfRecords { get; set; }
        public int? NoOfInvoices { get; set; }
        public int? NoOfCustomers { get; set; }
        public int? NoOfSuppliers { get; set; }
        public string? ServerUrl { get; set; }
        public string Package { get; set; } = null!;
        public string? LicensePlan { get; set; }
        public bool Status { get; set; }
        public bool MultipleCompany { get; set; }
        public bool Crm { get; set; }
        public bool ServiceManagement { get; set; }
        public bool Hrmsimple { get; set; }
        public bool Hrmadvance { get; set; }
        public bool Production { get; set; }
        public bool SimCardManagement { get; set; }
        public bool AdvanceSecurityModule { get; set; }
        public bool Manufacturing { get; set; }
        public bool Hotel { get; set; }
        public bool Resturant { get; set; }
        public bool Dashboard { get; set; }
        public bool? Branding { get; set; }
    }
}
