using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAllowanceEnhancementEmployeeDetail
    {
        public decimal Id { get; set; }
        public int AllowenceEnhancementId { get; set; }
        public int EmployeeId { get; set; }
        public int AllowanceId { get; set; }
    }
}
