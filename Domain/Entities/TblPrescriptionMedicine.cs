using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPrescriptionMedicine
    {
        public decimal PrescriptionId { get; set; }
        public decimal? ProductId { get; set; }
        public decimal? Uomid { get; set; }
        public string? Dosage { get; set; }
        public string? Intake { get; set; }
        public bool? AfterMeal { get; set; }
        public decimal? Days { get; set; }
        public string? Remarks { get; set; }
    }
}
