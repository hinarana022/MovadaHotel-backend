using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblComissionMapper
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int Employee { get; set; }
        public string StageId { get; set; } = null!;
        public string CommissionType { get; set; } = null!;
        public decimal Value { get; set; }
        public int? AvarageTime { get; set; }
        public int SubService { get; set; }
    }
}
