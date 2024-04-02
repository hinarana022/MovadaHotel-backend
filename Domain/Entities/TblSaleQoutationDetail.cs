﻿using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSaleQoutationDetail
    {
        public decimal SaleQoutationDetailsId { get; set; }
        public string QoutationId { get; set; } = null!;
        public string? Barcode { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? PriceInPkr { get; set; }
        public string? Category { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Uomid { get; set; }
        public string? Uomname { get; set; }
        public string? QuotationNumber { get; set; }
    }
}