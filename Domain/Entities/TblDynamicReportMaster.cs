using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDynamicReportMaster
    {
        public int Id { get; set; }
        public string? ReportName { get; set; }
        public string? ProcedureName { get; set; }
        public string? ReportHeader { get; set; }
        public string? ReportType { get; set; }
        public string? SpecialPersonName { get; set; }
        public string? SeperatorValue { get; set; }
        public bool? Date { get; set; }
        public bool? Header { get; set; }
        public bool? SpecialPerson { get; set; }
        public bool? Active { get; set; }
    }
}
