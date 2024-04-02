﻿using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPaymentMaster
    {
        public decimal PaymentMasterId { get; set; }
        public string? VoucherNo { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public decimal? LedgerId { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Narration { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public decimal? PaymentMethodId { get; set; }
        public decimal? CashierId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
