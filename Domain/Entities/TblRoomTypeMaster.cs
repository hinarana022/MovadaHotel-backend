using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class TblRoomTypeMaster
    {
        public decimal RoomTypeId { get; set; }
        public string? RoomTypeName { get; set; }
        public string? ShortName { get; set; }
        public string? BackColor { get; set; }
        public decimal? Rate { get; set; }
        public int? BaseAdult { get; set; }
        public int? BaseChild { get; set; }
        public int? MaxAdult { get; set; }
        public int? MaxChild { get; set; }
        public bool? IsExtraAdult { get; set; }
        public bool? IsExtraChild { get; set; }
        public int? ExtraAdult { get; set; }
        public int? ExtraChild { get; set; }
        public decimal? ExtraAdultPrice { get; set; }
        public decimal? ExtraChildPrice { get; set; }
        public string? Narration { get; set; }
        public bool? Isactive { get; set; }
        [NotMapped]
        public TblRoomTypeImage? tblRoomTypeImage { get; set; }

        [NotMapped]
        public List<TblAmenty>? tblAmenties { get; set; }
       
        
    }
}
