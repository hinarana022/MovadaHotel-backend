using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPatientVital
    {
        public decimal OpdTicketId { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? Bp { get; set; }
        public string? Symptoms { get; set; }
        public string? Pulse { get; set; }
        public string? Temperature { get; set; }
        public string? Respiration { get; set; }
        public string? BmiObesityStatus { get; set; }
        public string? Note { get; set; }
    }
}
