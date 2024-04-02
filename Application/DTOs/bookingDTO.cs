using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class bookingDTO
    {
        public int RoomTypeId { get; set; }
        public string? RoomTypeName { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string? PromoCode{ get; set; }
        public string guests{ get; set; }
    }
    public class bookingDTOGroup
    {
        public int RoomId { get; set; }
        public int total { get; set; }
    }
    public class bookinRoomStatusDTO
    {
        public decimal RoomId { get; set; }
        public decimal? Rate { get; set; }

        public string status { get; set; }
        public string ReservationNo { get; set; }
    }
    public class CheckoutDTO
    {
        public decimal LedgerId { get; set; }
        public string ReservationStatus { get; set; } = null!;
        public DateTime CheckIn { get; set; }

        public DateTime? CheckOut { get; set; }
        public decimal RoomTypeId { get; set; }
        public decimal RoomId { get; set; }

        public decimal GrandTotal { get; set; }
        public decimal Balance { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReservationDate { get; set; }
        public decimal PaymentMethodId { get; set; }

        public int guests { get; set; }
        public decimal SalesmanId { get; set; }

        public decimal LedgerCode { get; set; }
     
        public string? RoomTypeName { get; set; }

        public string StayType { get; set; } = null!;
        public decimal NoOfHours { get; set; }
        public decimal NoOfNights { get; set; }
        public decimal NoOfMonths { get; set; }


        public decimal NoOfAdults { get; set; }
        public decimal NoOfChilds { get; set; }
        public string? Reservation { get; set; }
        public decimal Discount { get; set; }
        public decimal PaidAmount { get; set; }
        public int? Shiftid { get; set; }
        public int? ShiftUserid { get; set; }
        public decimal? CityId { get; set; }
       
        public string? PromoCode { get; set; }
        public string Email { get; set; }
        public string? LedgerName { get; set; }
        public string? Mobile { get; set; }

    }
    public class SeasonDTO
    {
        public decimal SeasonID { get; set; }
        public int? SeasonTypeId { get; set; }
        public string SeasonName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation property to SeasonType
        public string SeasonType { get; set; }
    }
   
}
