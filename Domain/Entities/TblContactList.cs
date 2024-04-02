using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblContactList
    {
        public int ContactListId { get; set; }
        public string? ReceipentName { get; set; }
        public string? MobileNo { get; set; }
        public string? CountryCode { get; set; }
        public decimal? ContactGroupId { get; set; }
    }
}
