using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServicesCustomFieldsDatum
    {
        public decimal ServicesCustomFieldsDataId { get; set; }
        public decimal? ServicesCustomFieldsId { get; set; }
        public string? FieldName { get; set; }
        public string? Value { get; set; }
        public string? ServiceCode { get; set; }
        public string? Service { get; set; }
        public string? SaleInvoiceId { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal? RowId { get; set; }
    }
}
