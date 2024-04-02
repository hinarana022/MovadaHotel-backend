using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSingleSm
    {
        public int SingleSmsId { get; set; }
        public string? SingleContactNumber { get; set; }
        public string? SingleSmscompose { get; set; }
        public string? SelectTemplete { get; set; }
        public string? Status { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string? Smsgroup { get; set; }
        public string? SalesInvoiceId { get; set; }
        public string? SalesInstallmentId { get; set; }
    }
}
