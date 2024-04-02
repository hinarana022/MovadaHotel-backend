using Domain.Entities;

namespace Application.DTOs
{
    public class TblRoomBookingMasterDTO
    {
        public string ReservationStatus { get; set; } = null!;
        public DateTime ReservationDate { get; set; }
        public TimeSpan ReservationTime { get; set; }
        public string ReservationNo { get; set; } = null!;

        public DateTime ArrivalDate { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public string? RoomTypeName { get; set; }
        public decimal RoomTypeId { get; set; }
        public decimal RoomId { get; set; }
        public string roomName { get; set; }

        public int guests { get; set; }
        public decimal GrandTotal { get; set; }
        
        public TblRoomTypeImage? tblRoomTypeImage{ get; set; }

    }
    public partial class TblLedgerPostingDTO
    {
        public decimal LedgerPostingId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? VoucherTypeId { get; set; }
        public string? VoucherNo { get; set; }
        public decimal? LedgerId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? DetailsId { get; set; }
        public decimal? YearId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public decimal? SalesmanId { get; set; }
        public decimal? SalesStaffId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
