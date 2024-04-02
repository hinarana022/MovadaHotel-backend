using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblInstallmentsDefinition
    {
        public decimal InstallmentDefinitionId { get; set; }
        public decimal? Period { get; set; }
        public string? PeriodType { get; set; }
        public decimal? Interest { get; set; }
    }
}
