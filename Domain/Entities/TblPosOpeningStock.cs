using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPosOpeningStock
    {
        public int Id { get; set; }
        public string ItemCode { get; set; } = null!;
        public decimal PreviousQty { get; set; }
        public int Masterid { get; set; }
        public int Type { get; set; }
        public decimal ReceivedQty { get; set; }
    }
}
