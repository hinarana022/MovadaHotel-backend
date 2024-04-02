using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class RptviewLogHistoryDataView
    {
        public int UserId { get; set; }
        public int VoucherType { get; set; }
        public string UserName { get; set; } = null!;
        public string? VoucherTypeName { get; set; }
        public string VoucherNo { get; set; } = null!;
        public string? OperationDate { get; set; }
        public string OperationTime { get; set; } = null!;
        public string OperationType { get; set; } = null!;
    }
}
