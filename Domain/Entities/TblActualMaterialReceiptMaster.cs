using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblActualMaterialReceiptMaster
    {
        public string MaterialReceiptMasterId { get; set; } = null!;
        public string? MaterialReceiptNo { get; set; }
        public string? PurchaseInvoiceId { get; set; }
        public string? PurchaseInvoiceNo { get; set; }
        public string? VendorInvoiceNo { get; set; }
        public string? PurchaseOrderNo { get; set; }
        public string? ReceivedBy { get; set; }
        public decimal? SupplierId { get; set; }
        public string? SupplierRefNo { get; set; }
        public decimal? SalesmanId { get; set; }
        public DateTime? MaterialReceiptDocumentDate { get; set; }
        public DateTime? MaterialReceiptPostingDate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Total { get; set; }
        public string? Narration { get; set; }
        public string? Batch { get; set; }
    }
}
