using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDynamicReportDetail
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? ParameterName { get; set; }
    }
}
