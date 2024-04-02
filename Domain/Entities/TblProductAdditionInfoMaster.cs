using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProductAdditionInfoMaster
    {
        public decimal ProductAdditioninfoMasterId { get; set; }
        public string? ProductCode { get; set; }
        public string? FieldName { get; set; }
        public bool? ChkProductDef { get; set; }
        public bool? ChkInvoiceDef { get; set; }
        public bool? ChkSaleInvoiceDef { get; set; }
        public bool? ChkActivateOnSaleInvoiceReport { get; set; }
        public bool? ChkenableOnStockBarcode { get; set; }
    }
}
