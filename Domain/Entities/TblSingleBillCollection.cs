using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSingleBillCollection
    {
        public decimal SingleBillCollectionId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string? InvoiceTime { get; set; }
        public string? BillType { get; set; }
        public string? BillCompany { get; set; }
        public string? ReferenceNo { get; set; }
        public string? BillMonth { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? DueBill { get; set; }
        public decimal? AfterDueDate { get; set; }
        public decimal? CashPaid { get; set; }
        public decimal? Change { get; set; }
        public decimal? SalesmanId { get; set; }
        public string? SmsNo { get; set; }
    }
}
