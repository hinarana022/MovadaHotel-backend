using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRoomTariff
    {
        public decimal TariffId { get; set; }
        public string TariffType { get; set; } = null!;
        public int RoomTypeId { get; set; }
        public int RateTypeId { get; set; }
        public int? SeasonId { get; set; }
        public int? BuisnessSourceId { get; set; }
        public decimal Tariff { get; set; }
        public decimal? ExtraAdult { get; set; }
        public decimal? ExtraChild { get; set; }
    }
}
