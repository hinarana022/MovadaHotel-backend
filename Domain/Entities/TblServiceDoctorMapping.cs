using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServiceDoctorMapping
    {
        public decimal ServiceDoctorMappingId { get; set; }
        public decimal? EmployeeId { get; set; }
        public decimal? ServiceId { get; set; }
        public decimal? ServiceAmount { get; set; }
    }
}
