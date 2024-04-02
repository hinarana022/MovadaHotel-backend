using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBuisnessSource
    {
        public decimal BuisnessSourceId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int MarketPlaceId { get; set; }
        public string? Description { get; set; }
        public bool? Isactive { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? Address { get; set; }
        public string? PhoneNo { get; set; }
        public string? MobileNo { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? PlanType { get; set; }
        public decimal? Value { get; set; }
        public int? Terms { get; set; }
        public bool? SpeacialSeason { get; set; }
        public bool? SpecialRoomRates { get; set; }
    }
}
