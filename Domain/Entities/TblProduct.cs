using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProduct
    {
        public int ProductId { get; set; }
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? PrintName { get; set; }
        public int? GroupId { get; set; }
        public int? BrandId { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? UomgroupId { get; set; }
        public int? SizeId { get; set; }
        public int? TaxId { get; set; }
        public string? TaxapplicableOn { get; set; }
        public decimal? PurchaseRate { get; set; }
        public decimal? SalesRate { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? MinimumStock { get; set; }
        public decimal? MaximumStock { get; set; }
        public decimal? ReorderLevel { get; set; }
        public int? GodownId { get; set; }
        public int? RackId { get; set; }
        public string? IsallowBatch { get; set; }
        public string? Ismultipleunit { get; set; }
        public string? IsBom { get; set; }
        public string? Isopeningstock { get; set; }
        public string? Narration { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsshowRemember { get; set; }
        public string? Openingstock { get; set; }
        public string? Extra2 { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string? PartNo { get; set; }
        public string? Prefix { get; set; }
        public string? DefaultUomid { get; set; }
        public bool? IsInventoryItem { get; set; }
        public bool? Ispurchase { get; set; }
        public bool? ISalesItem { get; set; }
        public bool? IsPurchasesItem { get; set; }
        public bool? IsFixedAseet { get; set; }
        public bool? IsShowInReminder { get; set; }
        public string? PharmacyForeignKey { get; set; }
        public string? ResturantForeignKey { get; set; }
        public string? Description { get; set; }
        public decimal? SupplierId { get; set; }
        public bool? EnableBatch { get; set; }
        public bool? EnableExpiry { get; set; }
        public bool? IsSaleItem { get; set; }
        public bool? IsStockable { get; set; }
        public bool? IsRentalItem { get; set; }
        public bool? IsKotitem { get; set; }
        public bool? IsTaxable { get; set; }
        public bool? Extra1 { get; set; }
        public bool? Extra3 { get; set; }
        public string? Extra4 { get; set; }
        public bool? EnableWaranty { get; set; }
        public string? WarantyTypes { get; set; }
        public int? NoOfClaims { get; set; }
        public bool? Producible { get; set; }
        public string? ProductType { get; set; }
        public decimal? AccountGroupId { get; set; }
        public bool? ShiftWiseStockManage { get; set; }
        public string? MultiUomtype { get; set; }
        public decimal? NextPurchasePrice { get; set; }
        public bool? MultiBarcodes { get; set; }
        public decimal? ModelNoId { get; set; }
        public string? Model { get; set; }
        public decimal? ColorId { get; set; }
        public decimal? HorsePower { get; set; }
        public decimal? UnladenWeight { get; set; }
        public decimal? RegistrationFee { get; set; }
        public decimal? LiftTimeTokenFee { get; set; }
        public decimal? RegistrationBookFee { get; set; }
        public decimal? NumberPlateFee { get; set; }
        public decimal? TradePrice { get; set; }
        public decimal? PurchasePricePercent { get; set; }
        public decimal? SalePricePercent { get; set; }
        public bool? VariablePricing { get; set; }
        public decimal? DepartmentId { get; set; }
        public decimal? WholesaleRate { get; set; }
        public decimal? Size { get; set; }
        public bool? IsPriceBySize { get; set; }
        public string? Pksize { get; set; }
        public bool? IsPksize { get; set; }
    }
}
