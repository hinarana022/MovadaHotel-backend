using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServiceLog
    {
        public decimal ServiceId { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public decimal? ServiceCategoryId { get; set; }
        public decimal? Rate { get; set; }
        public string? Narration { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public string? UpdaterEmployeeId { get; set; }
        public string? UpdaterEmployeeName { get; set; }
        public string? UpdaterDate { get; set; }
        public string? UpdaterTime { get; set; }
    }
}
