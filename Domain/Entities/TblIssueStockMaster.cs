﻿using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblIssueStockMaster
    {
        public decimal IssueStockMasterId { get; set; }
        public string? IssueStockNo { get; set; }
        public DateTime? Date { get; set; }
        public decimal? IngredientsCost { get; set; }
        public string? Status { get; set; }
        public bool? IsApproved { get; set; }
        public string? Reference { get; set; }
        public string? Memo { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? SalesStaffId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
