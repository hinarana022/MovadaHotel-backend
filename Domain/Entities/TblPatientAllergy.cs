using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPatientAllergy
    {
        public decimal PatientallergyId { get; set; }
        public decimal? AllergyId { get; set; }
        public decimal? OpdTicketId { get; set; }
        public string? Serverity { get; set; }
        public string? Remarks { get; set; }
    }
}
