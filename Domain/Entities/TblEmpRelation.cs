using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblEmpRelation
    {
        public decimal RelationId { get; set; }
        public string? RelationName { get; set; }
        public string? Narration { get; set; }
    }
}
