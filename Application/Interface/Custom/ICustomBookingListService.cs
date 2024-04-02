using Application.DTOs;
using Domain.SP;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Custom
{
    public interface ICustomBookingListService
    {
        IQueryable<TblRoomBookingMasterDTO> GetAllAsync(int id);
        Task<bookinRoomStatusDTO> booknow(bookingDTO bookingDTO);
        Task<string> checkout(CheckoutDTO bookingDTO);
       Task<List<proc_LoadRoomTariff>> LoadReservationSeasonAsync();


    }
}
