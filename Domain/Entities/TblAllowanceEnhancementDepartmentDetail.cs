using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblAllowanceEnhancementDepartmentDetail
    {
        public decimal Id { get; set; }
        public int AllowenceEnhancementId { get; set; }
        public int DepartmentId { get; set; }
        public int AllowanceId { get; set; }
    }
}
