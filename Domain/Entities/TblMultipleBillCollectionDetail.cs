using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblMultipleBillCollectionDetail
    {
        public decimal MultipleBillCollectionDetailsId { get; set; }
        public decimal MultipleBillCollectionMasterId { get; set; }
        public string? ReferenceNo { get; set; }
        public string? BillMonth { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? DueBill { get; set; }
        public decimal? AfterDueDate { get; set; }
    }
}
