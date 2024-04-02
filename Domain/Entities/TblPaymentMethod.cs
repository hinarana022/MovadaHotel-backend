using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPaymentMethod
    {
        public decimal PaymentMethodId { get; set; }
        public string? PaymentMethod { get; set; }
        public string? Narration { get; set; }
    }
}
