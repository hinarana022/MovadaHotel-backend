using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBikeInfo
    {
        public decimal Id { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ProductCode { get; set; }
        public string? Uomid { get; set; }
        public string? Barcode { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public string? Model { get; set; }
        public string? EngineNo { get; set; }
        public string? ChasisNo { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public string? Status { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? DetailsId { get; set; }
    }
}
