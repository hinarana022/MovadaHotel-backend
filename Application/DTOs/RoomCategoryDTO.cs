using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class RoomCategoryDTO
    {
        public decimal RoomTypeId { get; set; }
        public string? RoomTypeName { get; set; }
        public decimal? Rate { get; set; }
        public int? BaseAdult { get; set; }
        public int? BaseChild { get; set; }
        public string? Narration { get; set; }

        public TblRoomTypeImage? tblRoomTypeImage { get; set; }

        public List<TblAmenty>? tblAmenties { get; set; }

        // public int AmentiesID { get; set; }



    }
}
