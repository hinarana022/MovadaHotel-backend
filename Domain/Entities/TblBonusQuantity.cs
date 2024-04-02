using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBonusQuantity
    {
        public int BonusQuantityId { get; set; }
        public int? InvoiceDetailsId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ProductCode { get; set; }
        public int? Uomid { get; set; }
        public int? Quantity { get; set; }
        public int? VoucherTypeId { get; set; }
    }
}
