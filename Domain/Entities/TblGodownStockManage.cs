using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGodownStockManage
    {
        public int GodownManageId { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Uomid { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? Expiry { get; set; }
        public string? GodownId { get; set; }
        public decimal? Qty { get; set; }
        public string? Extra { get; set; }
    }
}
