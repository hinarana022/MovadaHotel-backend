using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblWarrantyDetail
    {
        public int WarrantyDetailsId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ProductCode { get; set; }
        public int? Uomid { get; set; }
        public int? Condition { get; set; }
        public int? WarrantyType { get; set; }
        public int? WarrantyTerm { get; set; }
        public int? NoOfTerm { get; set; }
        public DateTime? WStart { get; set; }
        public DateTime? WEnd { get; set; }
        public string? WarrantyNo { get; set; }
        public string? Narration { get; set; }
        public int? VoucherTypeId { get; set; }
        public int? Claimed { get; set; }
        public int? NoOfClaims { get; set; }
        public bool? IsSold { get; set; }
    }
}
