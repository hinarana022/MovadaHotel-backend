﻿using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPosusersImage
    {
        public decimal EmployeeId { get; set; }
        public byte[] EmpImage { get; set; } = null!;
    }
}
