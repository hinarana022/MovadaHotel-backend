using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomFieldsSearchingDetail
    {
        public decimal CustomFieldDetailsId { get; set; }
        public decimal? CustomFieldMasterId { get; set; }
        public string? Value { get; set; }
    }
}
