using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblLogOperation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VoucherType { get; set; }
        public string VoucherNo { get; set; } = null!;
        public DateTime? OperationDate { get; set; }
        public string OperationTime { get; set; } = null!;
        public string OperationType { get; set; } = null!;
        public string RecordType { get; set; } = null!;
    }
}
