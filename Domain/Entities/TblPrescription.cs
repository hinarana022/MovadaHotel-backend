using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPrescription
    {
        public decimal PrescriptionId { get; set; }
        public DateTime? PrescriptionDate { get; set; }
        public decimal? OpdTicketId { get; set; }
        public bool? AdmitPatient { get; set; }
        public bool? ReferPatient { get; set; }
        public string? ProvisionalDiagnosis { get; set; }
        public string? Remarks { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string? OtherPrespiringComplaint { get; set; }
        public string? OtherInvestigations { get; set; }
        public string? Other { get; set; }
        public decimal? SalesmanId { get; set; }
        public bool? Investigation { get; set; }
        public bool? Management { get; set; }
        public decimal? DepartmentId { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
    }
}
