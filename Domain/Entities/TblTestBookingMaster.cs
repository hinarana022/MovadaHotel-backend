using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblTestBookingMaster
    {
        public int Id { get; set; }
        public string CaseId { get; set; } = null!;
        public string PatientNumber { get; set; } = null!;
        public DateTime Date { get; set; }
        public int TotalTests { get; set; }
        public decimal TestAmount { get; set; }
        public decimal Concession { get; set; }
        public decimal HomeCollection { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal Balance { get; set; }
        public bool? Status { get; set; }
        public DateTime? ReportDate { get; set; }
        public decimal? Paid { get; set; }
        public string? ReferedBy { get; set; }
        public decimal? ManualDiscount { get; set; }
    }
}
