using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEmployeeGatepass
    {
        public decimal? EmployeeGatepassId { get; set; }
        public string? EmployewGatepassNo { get; set; }
        public decimal? EmployeeId { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? ShiftId { get; set; }
        public string? Passtype { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string? Purpose { get; set; }
        public string? Reason { get; set; }
        public string? VehicleType { get; set; }
        public string? VehicleNo { get; set; }
        public string? EmployeeName { get; set; }
    }
}
