using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAccountLedger
    {
        public decimal LedgerId { get; set; }
        public string? LedgerCode { get; set; }
        public decimal? AccountGroupId { get; set; }
        public string? LedgerName { get; set; }
        public string? FathersName { get; set; }
        public string? OpeningBalance { get; set; }
        public bool? IsDefault { get; set; }
        public string? CrOrDr { get; set; }
        public string? Narration { get; set; }
        public string? MailingName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public int? CreditPeriod { get; set; }
        public string? CreditLimit { get; set; }
        public string? PricinglevelId { get; set; }
        public bool? BillByBill { get; set; }
        public string? Tin { get; set; }
        public string? Cst { get; set; }
        public string? Pan { get; set; }
        public decimal? RouteId { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public decimal? AreaId { get; set; }
        public string? Customercode { get; set; }
        public string? Cnic { get; set; }
        public string? CompanyName { get; set; }
        public string? MobileNo2 { get; set; }
        public string? City { get; set; }
        public string? PassportNo { get; set; }
        public bool? Status { get; set; }
        public string? PartyGroup { get; set; }
        public string? Route { get; set; }
        public string? Gender { get; set; }
        public string? ContactPerson { get; set; }
        public string? BankName { get; set; }
        public string? SwiftCode { get; set; }
        public string? BankAddress { get; set; }
        public string? BeneficiaryName { get; set; }
        public string? BeneficiaryAddress { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? DateOfRegistration { get; set; }
        public string? BloodGroup { get; set; }
        public string? Age { get; set; }
        public decimal? CreditLimitAmount { get; set; }
        public decimal? CreditLimitDays { get; set; }
        public bool? ExamptGst { get; set; }
        public string? Ntnno { get; set; }
        public string? Gstno { get; set; }
        public DateTime? OpeningBalanceDate { get; set; }
        public decimal? CityId { get; set; }
        public decimal? CasteId { get; set; }
        public DateTime? PromiseDate { get; set; }
        public string? CustomerShopName { get; set; }
        public string? GuestType { get; set; }
        public string? BirthPlace { get; set; }
        public string? RegNo { get; set; }
        public string? YearlyVist { get; set; }
        public decimal? IdentityId { get; set; }
        public string? IdentityType { get; set; }
        public string? IdState { get; set; }
        public string? IdCountry { get; set; }
        public DateTime? ValidDateFrom { get; set; }
        public DateTime? ValidDateTo { get; set; }
        public string? VehicleColo { get; set; }
        public string? VehicleCompany { get; set; }
        public string? VehicleLic { get; set; }
        public string? VehicleModel { get; set; }
        public string? VehicleState { get; set; }
        public string? UserLogin { get; set; }
        public string? Password { get; set; }
    }
}
