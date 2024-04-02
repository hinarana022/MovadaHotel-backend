using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblTestBookingpatient
    {
        public int Id { get; set; }
        public string PatientNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Dob { get; set; }
        public string? RefferedBy { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public string? Mobile { get; set; }
    }
}
