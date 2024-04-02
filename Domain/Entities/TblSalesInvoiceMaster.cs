using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSalesInvoiceMaster
    {
        public string SalesInvoiceId { get; set; } = null!;
        public string? SalesInvoiceNo { get; set; }
        public string? SalesTime { get; set; }
        public decimal? CustomerId { get; set; }
        public string? CustomerRefNo { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PricingLevelId { get; set; }
        public decimal? CurrencyId { get; set; }
        public decimal? ShipmentId { get; set; }
        public string? SalesInvoiceStatus { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountAllowed { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Interest { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalDownPayment { get; set; }
        public string? Narration { get; set; }
        public decimal? BalanceDue { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public DateTime? ExtraDate { get; set; }
        public decimal? PaymentMethodId { get; set; }
        public string? ShippingAddress { get; set; }
        public decimal? LedgerCode { get; set; }
        public decimal? CustomerLedgerBalance { get; set; }
        public decimal? SalesStaffId { get; set; }
        public decimal? CustomerSubAccountId { get; set; }
        public decimal? LeadId { get; set; }
        public int? ShiftUserid { get; set; }
        public int? Shiftid { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public decimal? LedgerIdForAutoMobile { get; set; }
        public string? TaxNumber { get; set; }
        public decimal? WarehouseId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
