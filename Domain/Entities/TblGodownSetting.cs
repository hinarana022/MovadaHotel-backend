using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGodownSetting
    {
        public string? DefaultInventoryMethod { get; set; }
        public bool? SaleBasedOnExpiry { get; set; }
        public bool? EnableExpiredBatchSale { get; set; }
    }
}
