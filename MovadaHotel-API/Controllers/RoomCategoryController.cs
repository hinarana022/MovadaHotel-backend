using Application.DTOs;
using Application.Interface.Custom;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovadaHotel_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomCategoryController : ControllerBase
    {
        private readonly ICustomRoomCategoryService _customRoomCategoryService;
        private readonly IMapper _mapper;

        public RoomCategoryController(ICustomRoomCategoryService customRoomCategoryService,IMapper mapper)
        {
            _customRoomCategoryService = customRoomCategoryService;
            _mapper=mapper;

        }

        [HttpGet("GetRoomCategories")]
        public async Task<IActionResult> GetRoomCategories()
        {
            try
            {
              var roomcategory = await _customRoomCategoryService.GetAllRoomsCategory();
                return Ok(roomcategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }
        [HttpGet("GetRoomCategoryDetailsbyId")]
        public async Task<IActionResult> GetRoomCategoryDetailsbyId(int id)
        {
            try
            {
                var roomcategory = await _customRoomCategoryService.GetAllRoomsCategorybyId(id);
                return Ok(roomcategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }
        
        
        
    }
}
