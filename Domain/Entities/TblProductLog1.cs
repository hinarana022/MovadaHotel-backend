using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProductLog1
    {
        public int ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public int? GroupId { get; set; }
        public int? BrandId { get; set; }
        public int? Uomid { get; set; }
        public decimal? UomgroupId { get; set; }
        public int? SizeId { get; set; }
        public int? ModelNoId { get; set; }
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
        public string? Barcode { get; set; }
        public string? Prefix { get; set; }
        public string? DefaultUomid { get; set; }
        public bool? IsInventoryItem { get; set; }
        public bool? Ispurchase { get; set; }
        public bool? ISalesItem { get; set; }
        public bool? IsPurchasesItem { get; set; }
        public bool? IsFixedAseet { get; set; }
        public bool? IsShowInReminder { get; set; }
        public string? ProductType { get; set; }
        public string? PharmacyForeignKey { get; set; }
        public string? ResturantForeignKey { get; set; }
        public string? Description { get; set; }
        public int? ColorId { get; set; }
        public string? UpdaterEmployeeId { get; set; }
        public string? UpdaterEmployeeName { get; set; }
        public string? UpdaterDate { get; set; }
        public string? UpdaterTime { get; set; }
    }
}
