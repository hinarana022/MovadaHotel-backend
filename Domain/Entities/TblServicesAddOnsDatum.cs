using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblServicesAddOnsDatum
    {
        public decimal ServicesAddOnsDataId { get; set; }
        public decimal? ServicesAddOnFieldsId { get; set; }
        public string? AddOnName { get; set; }
        public bool? IsOptional { get; set; }
        public string? ServiceCode { get; set; }
        public string? Service { get; set; }
        public string? SaleInvoiceId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? CustomerId { get; set; }
        public bool? IsSelected { get; set; }
        public decimal? RowId { get; set; }
    }
}
