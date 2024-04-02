using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblVoucherTypeTax
    {
        public decimal VoucherTypeTaxId { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public decimal? TaxId { get; set; }
    }
}
