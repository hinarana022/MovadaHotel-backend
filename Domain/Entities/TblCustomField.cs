using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomField
    {
        public decimal CustomFieldsId { get; set; }
        public decimal? ProductGroupId { get; set; }
        public string? FieldName { get; set; }
    }
}
