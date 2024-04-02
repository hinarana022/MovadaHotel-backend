using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblReportSetting
    {
        public string TestCat { get; set; } = null!;
        public string TestName { get; set; } = null!;
        public int Rowindex { get; set; }
    }
}
