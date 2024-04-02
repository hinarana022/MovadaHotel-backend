using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSmstemplate
    {
        public int TamplateId { get; set; }
        public string TemplateCode { get; set; } = null!;
        public string? TemplateName { get; set; }
        public string? Template { get; set; }
        public bool? IsActive { get; set; }
        public decimal? VoucherTypeId { get; set; }
    }
}
