using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServicesCustomField
    {
        public decimal ServicesCustomFieldsId { get; set; }
        public string? ServiceCode { get; set; }
        public string? FieldName { get; set; }
    }
}
