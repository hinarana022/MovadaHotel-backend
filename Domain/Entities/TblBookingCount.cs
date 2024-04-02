using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblBookingCount
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MaxCount { get; set; }
    }
}
