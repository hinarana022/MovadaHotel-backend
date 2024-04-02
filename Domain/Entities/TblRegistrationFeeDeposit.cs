using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRegistrationFeeDeposit
    {
        public decimal RegistrationFeeDespositId { get; set; }
        public string? RegistrationFeeDespositNo { get; set; }
        public DateTime? DepositDate { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal? RegistrationFee { get; set; }
        public decimal? LiftTimeTokenFee { get; set; }
        public decimal? RegistrationBookFee { get; set; }
        public decimal? NumberPlateFee { get; set; }
        public decimal? ExtraFee { get; set; }
        public decimal? Total { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? BalanceDue { get; set; }
        public string? Remarks { get; set; }
        public decimal? LedgerId { get; set; }
        public string? LetterId { get; set; }
        public string? InvoiceNo { get; set; }
    }
}
