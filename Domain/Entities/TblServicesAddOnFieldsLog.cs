using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServicesAddOnFieldsLog
    {
        public decimal ServicesAddOnFieldsId { get; set; }
        public string? ServiceCode { get; set; }
        public string? AddOnName { get; set; }
        public bool? IsOptional { get; set; }
        public decimal? Amount { get; set; }
        public string? UpdaterEmployeeId { get; set; }
        public string? UpdaterEmployeeName { get; set; }
        public string? UpdaterDate { get; set; }
        public string? UpdaterTime { get; set; }
    }
}
