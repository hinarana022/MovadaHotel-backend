using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomFieldsSearchMapping
    {
        public decimal CustomFieldMappingId { get; set; }
        public decimal? ProductId { get; set; }
        public decimal CustomFieldMasterId { get; set; }
        public decimal? CustomFieldDetailsId { get; set; }
    }
}
