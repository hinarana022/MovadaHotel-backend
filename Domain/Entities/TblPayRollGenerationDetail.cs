using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPayRollGenerationDetail
    {
        public decimal PayRollGenerationDetailId { get; set; }
        public decimal PayRollGenerationId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TotalMinutes { get; set; }
        public decimal TotalHours { get; set; }
        public decimal TotalHalfDays { get; set; }
        public decimal TotalFullDays { get; set; }
        public decimal ActualDays { get; set; }
        public decimal ApproveDays { get; set; }
        public decimal BasicPayAmount { get; set; }
        public decimal TotalEarningAmount { get; set; }
        public decimal TotalDeductionAmount { get; set; }
        public decimal TotalAllowanceAmount { get; set; }
        public decimal TotalLoanAmount { get; set; }
        public decimal FinalTotal { get; set; }
    }
}
