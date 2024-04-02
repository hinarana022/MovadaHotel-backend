using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblUnitsOfMeasurementGroup
    {
        public int MeasurementGroupsId { get; set; }
        public string? GroupsCode { get; set; }
        public string? GroupsIname { get; set; }
        public string? Description { get; set; }
    }
}
