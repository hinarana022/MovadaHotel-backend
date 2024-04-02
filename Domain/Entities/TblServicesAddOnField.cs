using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServicesAddOnField
    {
        public decimal ServicesAddOnFieldsId { get; set; }
        public string? ServiceCode { get; set; }
        public string? AddOnName { get; set; }
        public bool? IsOptional { get; set; }
        public decimal? Amount { get; set; }
    }
}
