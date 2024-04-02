using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGeneralPrescriptionRadioOption
    {
        public decimal PrescriptionId { get; set; }
        public string? SystematicExamination { get; set; }
        public string? Cvsexamination { get; set; }
        public string? RespirationExamination { get; set; }
        public string? Gitexamination { get; set; }
        public string? Cnsexamination { get; set; }
        public string? ThyroidExamination { get; set; }
        public string? RheumatologicalExamination { get; set; }
        public string? GeneralUrinaryExamination { get; set; }
    }
}
