using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplicationFormSettingSqltable
    {
        public string FormName { get; set; } = null!;
        public string? Sqltable { get; set; }
        public string? Key { get; set; }
    }
}
