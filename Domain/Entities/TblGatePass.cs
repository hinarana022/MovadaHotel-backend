using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGatePass
    {
        public decimal? GatepassId { get; set; }
        public string? GatepassNo { get; set; }
        public decimal? EmployeeId { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? ShiftId { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string? VehicleType { get; set; }
        public string? VehicleNo { get; set; }
        public decimal? PehlaWasan { get; set; }
        public decimal? DosraWasan { get; set; }
        public decimal? SafiWasan { get; set; }
        public decimal? CompanyId { get; set; }
    }
}
