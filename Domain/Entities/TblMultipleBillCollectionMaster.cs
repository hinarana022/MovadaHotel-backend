using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMultipleBillCollectionMaster
    {
        public decimal MultipleBillCollectionMasterId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string? InvoiceTime { get; set; }
        public string? BillType { get; set; }
        public string? BillCompany { get; set; }
        public decimal? DueBill { get; set; }
        public decimal? CashPaid { get; set; }
        public decimal? Change { get; set; }
        public decimal? SalesmanId { get; set; }
        public string? SmsNo { get; set; }
    }
}
