using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCustomFieldsSearchingMaster
    {
        public decimal CustomFieldMasterId { get; set; }
        public string? CustomerFieldName { get; set; }
        public string? SelectionType { get; set; }
    }
}
