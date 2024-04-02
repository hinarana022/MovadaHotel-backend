using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeIncrementDetail
    {
        public decimal IncrementDetailsId { get; set; }
        public string IncrementType { get; set; } = null!;
        public DateTime DocumentDate { get; set; }
        public decimal EmployeeId { get; set; }
        public string IncrementPeriod { get; set; } = null!;
        public decimal IncrementValue { get; set; }
        public string IncrementBasis { get; set; } = null!;
        public decimal IncrementBasisValue { get; set; }
        public DateTime IncrementDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal CurrentBasicPay { get; set; }
        public decimal IncrementedValue { get; set; }
        public decimal UpdatedBasicPay { get; set; }
    }
}
