using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProductionMaster
    {
        public decimal ProductionMasterId { get; set; }
        public string? ProductionNo { get; set; }
        public DateTime? Date { get; set; }
        public decimal? ProductId { get; set; }
        public decimal? Uomid { get; set; }
        public decimal? ProducedQty { get; set; }
        public decimal? IngredientsCost { get; set; }
        public decimal? Expenses { get; set; }
        public decimal? AverageCostPrice { get; set; }
        public decimal? AverageUnitPrice { get; set; }
    }
}
