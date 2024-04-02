using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProfitAnalysisReport
    {
        public decimal ProfitReportId { get; set; }
        public DateTime? Date { get; set; }
        public string? Time { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public string? BatchNo { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Discount { get; set; }
        public decimal? RowTotal { get; set; }
        public decimal? UnitPurchasePrice { get; set; }
        public decimal? AvgUnitDiscount { get; set; }
        public decimal? AvgUnitFreight { get; set; }
        public decimal? AvgUnitOtherExpense { get; set; }
        public decimal? ActualUnitCost { get; set; }
        public decimal? SoldStockValue { get; set; }
        public decimal? ActualSoldStockValue { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? ReturnValue { get; set; }
        public decimal? SaleProfit { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
    }
}
