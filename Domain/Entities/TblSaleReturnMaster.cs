using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSaleReturnMaster
    {
        public string SaleReturnMasterId { get; set; } = null!;
        public string? SalesInvoiceId { get; set; }
        public string? SalesInvoiceNo { get; set; }
        public decimal? CustomerId { get; set; }
        public string? CustomerRefNo { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public decimal? CurrencyId { get; set; }
        public DateTime? SaleInvoicePostingDate { get; set; }
        public DateTime? SaleInvoiceDeliveryDate { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? SaleReturnDate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountAllowed { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Total { get; set; }
        public string? SaleReturnNarration { get; set; }
        public string? SaleReturnNo { get; set; }
        public decimal? SaleInvoiceSubtotal { get; set; }
        public decimal? SaleInvoiceDiscount { get; set; }
        public decimal? SaleInvoiceFreight { get; set; }
        public decimal? SaleInvoiceTotal { get; set; }
        public decimal? SaleInvoiceDownPayment { get; set; }
        public decimal? SaleInvoiceBalance { get; set; }
        public decimal? ReturnAmount { get; set; }
        public decimal? BalanceDue { get; set; }
        public int? ShiftUserid { get; set; }
        public int? Shiftid { get; set; }
        public decimal? WarehouseId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
