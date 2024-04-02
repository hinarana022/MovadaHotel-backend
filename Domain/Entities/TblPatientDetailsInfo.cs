using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPatientDetailsInfo
    {
        public decimal PatientDetailsInfoId { get; set; }
        public decimal LedgerId { get; set; }
        public string? DepartmentType { get; set; }
        public decimal? SpecialityGroupId { get; set; }
        public decimal? SpecialityId { get; set; }
        public decimal? SpecialityUnitId { get; set; }
        public decimal? SpecialityWardId { get; set; }
        public decimal? SpecialityProcedureId { get; set; }
        public string? ProcedureType { get; set; }
        public string? DifferentialDiagnosis { get; set; }
        public decimal? RefferedDepartmentId { get; set; }
    }
}
