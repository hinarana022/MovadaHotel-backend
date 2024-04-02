using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGodownPackingLog
    {
        public int GodownPackingLogId { get; set; }
        public string? FromProductCode { get; set; }
        public decimal? FromUomid { get; set; }
        public decimal? FromGodownId { get; set; }
        public string? FromBatch { get; set; }
        public decimal? FromQuantity { get; set; }
        public string? ToProductCode { get; set; }
        public decimal? ToUomid { get; set; }
        public decimal? ToGodownId { get; set; }
        public string? ToBatch { get; set; }
        public decimal? ToQuantity { get; set; }
        public DateTime? FromExpiry { get; set; }
        public DateTime? ToExpiry { get; set; }
    }
}
