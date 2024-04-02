using Application;
using Application.DTOs;
using Application.Interface;
using Application.Interface.Custom;
using AutoMapper;
using Humanizer;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MovadaHotel_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomBookingController : ControllerBase
    {
        private readonly ICustomBookingListService _customBookingList;
        private readonly IMapper _mapper;

        public RoomBookingController(IMapper mapper, ICustomBookingListService customBookingList)
        {
            _mapper = mapper;
            _customBookingList = customBookingList;
        }


        [HttpGet("GetAllBookingList")]
        public async Task<IActionResult> GetAllBookingList(int id)
        {
            try
            {
                var bookings = await _customBookingList.GetAllAsync(id).ToListAsync();
                return Ok(bookings);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }


       
        [HttpPost("bookNow")]
        public async Task<IActionResult> bookNow([FromBody]  bookingDTO dto)
        {
            try
            {
                // var seasons = await _customBookingList.LoadReservationSeasonAsync();
               
                var bookings = await _customBookingList.booknow( dto);
                return Ok(new {  bookings.status,bookings.RoomId,bookings.Rate,bookings.ReservationNo });
               // return Ok(new { status = bookings.status,bookings.RoomId,bookings.Rate });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPost("testSp")]
        public async Task<IActionResult> testSp()   
        {
            try
            {
                var bookings = await _customBookingList.LoadReservationSeasonAsync();
                return Ok(bookings);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }
        [HttpPost("checkout")]
        public async Task<IActionResult> checkout(CheckoutDTO dto)
        {
            try
            {
                var bookings = await _customBookingList.checkout(dto);
                if (bookings != null) {
                    if (bookings == "Successfully added.")
                    {
                        return Ok(new { bookings });
                    } 
                }
                    return StatusCode(500, $"Internal server error: {bookings}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }

    }
}
