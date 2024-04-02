using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEpurchaseOrderMaster
    {
        public decimal PurchaseOrderMasterId { get; set; }
        public string? PurchaseOrderId { get; set; }
        public string? PurchaseOrderNo { get; set; }
        public string? ContractNo { get; set; }
        public DateTime? ContractDate { get; set; }
        public string? ReferenceNo { get; set; }
        public string? Status { get; set; }
        public string? PortOfLanding { get; set; }
        public string? PortOfDischarge { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? FinancialTerms { get; set; }
        public string? Origin { get; set; }
        public string? Consignee { get; set; }
        public string? NoOfFcl { get; set; }
        public string? TypeOfFcl { get; set; }
        public decimal? SupplierId { get; set; }
        public decimal? CurrencyId { get; set; }
        public string? SpecialRequirments { get; set; }
        public string? CourierAddress { get; set; }
        public string? Narration { get; set; }
        public string? ImportantRemarks { get; set; }
        public decimal? ExtraDiscount { get; set; }
        public decimal? TotalFob { get; set; }
        public decimal? TotalFreight { get; set; }
        public decimal? TotalInsurance { get; set; }
        public decimal? TotalCif { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? BalanceDue { get; set; }
        public string? Quantity { get; set; }
        public string? Terms { get; set; }
        public string? NotifyParty { get; set; }
        public decimal? Extra1 { get; set; }
        public DateTime? Extra2 { get; set; }
        public string? Extra3 { get; set; }
    }
}
