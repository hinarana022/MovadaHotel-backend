﻿using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGeneralSetting
    {
        public bool? EnableInstallments { get; set; }
        public bool? EnableAutoSmsSender { get; set; }
        public bool? EnableDefaultPrint { get; set; }
        public bool? EnableSmallReceipt { get; set; }
        public bool? EnableMultipleUom { get; set; }
        public bool? EnableReminder { get; set; }
        public bool? EnableDummyInvoice { get; set; }
        public bool? EnablePromotions { get; set; }
        public bool? Multicurrency { get; set; }
        public int? DefaultCurrencyId { get; set; }
        public int? DefaultpricingLevelId { get; set; }
        public bool? ShowShortStockItems { get; set; }
        public bool? PrintForEmployees { get; set; }
        public bool? PrintTickets { get; set; }
        public string? DefaultSmsSendingDevice { get; set; }
        public string? InventorySettings { get; set; }
        public bool? PrintLabelsOnPi { get; set; }
        public bool? ShowProdCodeOnSireport { get; set; }
        public bool? ShowExpiryOnSireport { get; set; }
        public bool? ShowBarcodeOnSireport { get; set; }
        public bool? SalePriceEditableInSi { get; set; }
        public bool? PurchasePriceEditableInPi { get; set; }
        public bool? EnablePurchasePriceChangeInPi { get; set; }
        public bool? EnableSalePriceChangeOnPi { get; set; }
        public bool? EnableSalePriceChangeOnSi { get; set; }
        public string? DefaultSaleInvoiceSearchOption { get; set; }
        public string? DefaultImagePath { get; set; }
        public bool? ShowZeroStockProudcts { get; set; }
        public string? ProductSorting { get; set; }
        public bool? ShowBatchOnSi { get; set; }
        public string? NoOfDefaultProducts { get; set; }
        public bool? ShowAdvancedSearchOnSi { get; set; }
        public string? DefaultPaperSize { get; set; }
        public int? DefaultMop { get; set; }
        public bool? Branding { get; set; }
        public bool? ShowBatchonInvoices { get; set; }
        public bool? ShowExpiryonInvoices { get; set; }
        public bool? ShowBonusQtyonInvoices { get; set; }
        public bool? EnableWarrantySystem { get; set; }
        public bool? ShowDiscountPercentageonInvoices { get; set; }
        public bool? PrintBatchonInvoices { get; set; }
        public bool? PrintExpiryonInvoices { get; set; }
        public bool? PrintBonusQuantityInvoicesonInvoices { get; set; }
        public bool? PrintWarrantyDetailsOnInvoices { get; set; }
        public decimal? ExpiryBeforeDays { get; set; }
        public string? InvoiceNote { get; set; }
        public bool? ShowInvoiceNoteOnInvoices { get; set; }
        public bool? EnableAdditionalColumns { get; set; }
        public bool? ShowDiscountOnInvoices { get; set; }
        public bool? ShowTaxesOnInvoices { get; set; }
        public bool? ShowNarrationOnInvoices { get; set; }
        public bool? EnableMembership { get; set; }
        public decimal? InvoiceBeforeDays { get; set; }
        public decimal? DueDateAfterDays { get; set; }
        public bool? Pkrfunction { get; set; }
        public bool? EnableStages { get; set; }
        public bool? EnableCalender { get; set; }
        public string? SaleSelection { get; set; }
        public bool? ShowDisandHideTax { get; set; }
        public bool? LoadPrevDiscOnSi { get; set; }
        public bool? SaveProductNames { get; set; }
        public bool? ShowPharmacySireport { get; set; }
        public decimal? DefaultCustomerGroup { get; set; }
        public string? PrinterForKitchen { get; set; }
        public string? PrinterForSmallInvoice { get; set; }
        public string? PrinterForLargeInvoice { get; set; }
        public string? SmsNote { get; set; }
        public bool? ShowSmsnote { get; set; }
        public bool? SendOnSaleSms { get; set; }
        public bool? TakeAutoBackup { get; set; }
        public bool? CashFlowEnabled { get; set; }
        public bool? SendSmsonReceiptVoucher { get; set; }
        public bool? SendSmsonPaymentVoucher { get; set; }
        public bool? SendSmsonInstallmentVoucher { get; set; }
        public bool? SendSmsonInstallmentVoucherRegister { get; set; }
        public bool? EnableMultiBaseUomsystem { get; set; }
        public bool? ProfitRptOnAvgPurCost { get; set; }
        public bool? TravelAgencySetup { get; set; }
        public string? CustomName1 { get; set; }
        public string? CustomName2 { get; set; }
        public string? CustomName3 { get; set; }
        public string? CustomUnitFormName { get; set; }
        public string? ReportTitle { get; set; }
        public string? InvoiceTemplate { get; set; }
        public bool? SmallReceiptPreview { get; set; }
        public bool? ShowBarcode { get; set; }
        public bool? EnableTpvalue { get; set; }
        public bool? EnableMaintainDiscOnTp { get; set; }
        public string? DefaultMultiUom { get; set; }
        public string? DefaultMultiUomtype { get; set; }
        public bool? ShowPrintName { get; set; }
        public string? UomfieldType { get; set; }
        public bool? AllowSaveStockInMinus { get; set; }
        public bool? AutoGenerateInvoice { get; set; }
        public string? DefaultLanguage { get; set; }
        public bool? EnableScheduler { get; set; }
        public string? DepartureTime { get; set; }
        public bool? MarraigeHallSetup { get; set; }
        public bool? ShowAvailableQty { get; set; }
        public bool? ShowSelectProject { get; set; }
        public bool? ShowInvoicePertainsTo { get; set; }
        public bool? ShowInoviceNo { get; set; }
        public bool? ShowBorrowedFromTo { get; set; }
        public bool? ShowPaid { get; set; }
        public bool? ShowSelectCheque { get; set; }
        public bool? ShowChequeNo { get; set; }
        public bool? ShowIssueDate { get; set; }
        public bool? ShowChequeDate { get; set; }
        public bool? ShowNarration { get; set; }
        public bool? ShowBalance { get; set; }
        public bool? ShowAdvertisementVideo { get; set; }
        public bool? InvoiceSelection { get; set; }
        public bool? DefaultZeroQuantity { get; set; }
        public bool? ShowPonoInPi { get; set; }
        public string? DefaultBarcodePrinter { get; set; }
        public string? CalculateProfitBasedOn { get; set; }
        public bool? ShowPurchasePrice { get; set; }
        public string? DefaultSticker { get; set; }
        public string? ShowStockTypeonPos { get; set; }
        public bool? HrmdataRestrictions { get; set; }
        public string? KotprintType { get; set; }
        public bool? EncryptPurchasePrice { get; set; }
        public decimal? BillDiscount { get; set; }
        public bool? LoadLastSalePrice { get; set; }
        public bool? GenerateOpdticketWrtDoc { get; set; }
        public bool? UrduInvoice { get; set; }
        public string? NoOfPrintOuts { get; set; }
        public bool? ShowGrammage { get; set; }
        public string? ThermalPrintType { get; set; }
        public bool? EnableWarehouse { get; set; }
        public bool? ShowDiscount { get; set; }
        public bool? ShowCompanyLogoInInvoice { get; set; }
        public bool? ShowBarcodeInInvoice { get; set; }
        public bool? SpaerateGrnProcess { get; set; }
        public decimal? CancellationFeePercentage { get; set; }
    }
}