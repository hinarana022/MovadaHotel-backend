using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Custom
{
    public interface ICustomRoomCategoryService
    {
        Task<List<RoomCategoryDTO>> GetAllRoomsCategory();
        Task<List<RoomCategoryDTO>> GetAllRoomsCategorybyId(int id);
        //IQueryable<RoomCategoryDTO> GetRoomCategoryDetailsbyId(int id);

    }
}
