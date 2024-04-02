using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblShipmentType
    {
        public decimal ShipmentId { get; set; }
        public string? ShipmentTypeName { get; set; }
        public string? Narration { get; set; }
    }
}
