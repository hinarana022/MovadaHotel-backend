using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblTestBookingDetail
    {
        public int Id { get; set; }
        public string CaseId { get; set; } = null!;
        public string TestId { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal TaxAmount { get; set; }
        public string? Status { get; set; }
        public string? TestName { get; set; }
    }
}
