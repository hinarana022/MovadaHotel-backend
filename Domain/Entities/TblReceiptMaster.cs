using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblReceiptMaster
    {
        public decimal ReceiptMasterId { get; set; }
        public string? VoucherNo { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public decimal? LedgerId { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Narration { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public string? Mop { get; set; }
        public decimal? PaymentMethodId { get; set; }
        public decimal? CashierId { get; set; }
        public decimal? SalesStaffId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
