using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ITblRoomBookingMasterService
    {
        Task<List<TblRoomBookingMasterDTO>> GetAllAsync();
        Task AddAsync(TblRoomBookingMasterDTO entity);
        Task UpdateAsync(TblRoomBookingMasterDTO entity);
        Task DeleteAsync(TblRoomBookingMasterDTO entity);

    }
}
