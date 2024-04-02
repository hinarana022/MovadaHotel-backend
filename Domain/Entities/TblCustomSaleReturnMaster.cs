using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomSaleReturnMaster
    {
        public string CustomSaleReturnId { get; set; } = null!;
        public string? CustomSaleReturnNo { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? BalanceDue { get; set; }
        public string? CustomSaleReturnNarration { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public decimal? Shiftid { get; set; }
        public decimal? ShiftUserid { get; set; }
    }
}
