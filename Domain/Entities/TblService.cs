using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblService
    {
        public decimal ServiceId { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public decimal? ServiceCategoryId { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Rate { get; set; }
        public string? Narration { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxable { get; set; }
        public bool? IsTicketable { get; set; }
        public bool? InfoReq { get; set; }
        public bool? ChkisPkr { get; set; }
        public string? PrintName { get; set; }
    }
}
