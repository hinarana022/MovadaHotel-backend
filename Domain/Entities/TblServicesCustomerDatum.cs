using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServicesCustomerDatum
    {
        public decimal ServicesCustomerDataId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal? ServiceId { get; set; }
        public decimal? ServicesCustomFieldsId { get; set; }
        public string? Value { get; set; }
    }
}
