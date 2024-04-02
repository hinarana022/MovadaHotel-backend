using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblReturnIssueStockMaster
    {
        public decimal ReturnIssueStockMasterId { get; set; }
        public string? ReturnIssueStockNo { get; set; }
        public decimal IssueStockMasterId { get; set; }
        public string? IssueStockNo { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? IngredientsCost { get; set; }
        public string? Status { get; set; }
        public string? Memo { get; set; }
        public decimal? PricingLevelId { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? SalesStaffId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
