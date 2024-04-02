using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblInvoiceGenerationStatus
    {
        public decimal PrescriptionId { get; set; }
        public bool? InvoiceGenerated { get; set; }
        public string? InvoiceNo { get; set; }
        public bool? LabInvoiceStatus { get; set; }
        public string? LabInvoiceNo { get; set; }
    }
}
