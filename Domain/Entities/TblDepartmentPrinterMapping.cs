using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDepartmentPrinterMapping
    {
        public decimal DepartmentId { get; set; }
        public string? Printer { get; set; }
    }
}
