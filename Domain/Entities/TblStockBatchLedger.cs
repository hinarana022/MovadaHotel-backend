using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblStockBatchLedger
    {
        public int Id { get; set; }
        public string? InvoiceId { get; set; }
        public int? DetailsId { get; set; }
        public string? ProductId { get; set; }
        public int? Uomid { get; set; }
        public DateTime? Date { get; set; }
        public string? Batch { get; set; }
        public string? Method { get; set; }
        public int? Operation { get; set; }
        public int? NewQty { get; set; }
        public int? PreviousQty { get; set; }
        public int? AddedQty { get; set; }
    }
}
