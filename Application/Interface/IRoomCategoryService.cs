using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IRoomCategoryService
    {
        Task<RoomCategoryDTO> GetAllRoomsCategory();
        Task<RoomCategoryDTO> GetRoomCategoryDetailsbyId(int id);
        Task<RoomCategoryDTO> roomBooking(RoomCategoryDTO roomCategoryDTO);

    }
}
