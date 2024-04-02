using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblWarranty
    {
        public int WarrantyId { get; set; }
        public int? InvoiceDetailsId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ProductCode { get; set; }
        public int? Uomid { get; set; }
        public string? WarrantyNo { get; set; }
        public int? VoucherTypeId { get; set; }
    }
}
