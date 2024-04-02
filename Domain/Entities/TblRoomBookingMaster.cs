using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class TblRoomBookingMaster
    {
        public decimal ReservationId { get; set; }
        public decimal LedgerId { get; set; }
        public decimal LedgerCode { get; set; }
        public string LedgerName { get; set; } = null!;
        public string? FathersName { get; set; }
        public string? Cnic { get; set; }
        public string? Mobile { get; set; }
        public string? City { get; set; }
        public decimal RoomTypeId { get; set; }
        public decimal RoomId { get; set; }
        [NotMapped]

        public string roomName { get; set; }
        public decimal? SeasonTypeId { get; set; }
        public decimal? SeasonId { get; set; }
        public decimal RateTypeId { get; set; }
        public string ReservationStatus { get; set; } = null!;
        public DateTime ReservationDate { get; set; }
        public TimeSpan ReservationTime { get; set; }
        public string ReservationNo { get; set; } = null!;
        public string FolioNo { get; set; } = null!;
        public string StayType { get; set; } = null!;
        public decimal NoOfHours { get; set; }
        public decimal NoOfNights { get; set; }
        public decimal NoOfMonths { get; set; }
        public DateTime ArrivalDate { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public decimal NoOfAdults { get; set; }
        public decimal NoOfChilds { get; set; }
        public string? GuestRemarks { get; set; }
        public string? Reservation { get; set; }
        public string? CheckIn { get; set; }
        public string? CheckOut { get; set; }
        public string? Cancellation { get; set; }
        public string? HouseKeeping { get; set; }
        public string? EarlyCheckIn { get; set; }
        public string? EarlyCheckOut { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal PaidAmount { get; set; }
        public int? Shiftid { get; set; }
        public int? ShiftUserid { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? PaymentMethodId { get; set; }
        public decimal? CityId { get; set; }
    }
}
