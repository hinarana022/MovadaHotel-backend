using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoute
    {
        public decimal RouteId { get; set; }
        public string? RouteName { get; set; }
        public decimal? AreaId { get; set; }
        public string? Narration { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
    }
}
