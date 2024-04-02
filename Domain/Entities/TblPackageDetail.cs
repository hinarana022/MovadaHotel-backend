using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPackageDetail
    {
        public decimal PackagesDetailId { get; set; }
        public int? PackageId { get; set; }
        public int? RoomTypeId { get; set; }
        public int? BaseOccupancy { get; set; }
        public int? HigherOccupancy { get; set; }
        public int? BasePrice { get; set; }
        public int? HighPrice { get; set; }
        public int? ExtraBedPrice { get; set; }
        public int? Adult { get; set; }
        public int? Children { get; set; }
    }
}
