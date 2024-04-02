using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMEmployeeEducationDetail
    {
        public decimal EducationDetailsId { get; set; }
        public decimal EmployeeId { get; set; }
        public string? EducationLevel { get; set; }
        public string? DegreeName { get; set; }
        public string? EmpGroup { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? MarksPercentage { get; set; }
        public string? EvaluationType { get; set; }
        public string? Status { get; set; }
        public string? Result { get; set; }
        public string? Distinction { get; set; }
    }
}
