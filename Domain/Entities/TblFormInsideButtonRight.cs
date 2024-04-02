using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblFormInsideButtonRight
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserType { get; set; } = null!;
        public string FormName { get; set; } = null!;
        public int RightBtnView { get; set; }
        public int RightBtnSave { get; set; }
        public int RightBtnUpdate { get; set; }
        public int RightBtnDelete { get; set; }
        public int RightDetailDiscount { get; set; }
        public int RightTotalDiscount { get; set; }
        public int RightExtraDiscount { get; set; }
    }
}
