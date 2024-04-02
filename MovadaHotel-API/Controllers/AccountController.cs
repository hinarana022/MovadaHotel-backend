using Application;
using Application.DTOs;
using Application.Interface;
using Application.Services;
using AutoMapper;
using AutoMapper.Execution;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;

namespace MovadaHotel_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;


        public AccountController(IUserService userService,IMapper mapper, IConfiguration configuration)
        {
            _userService = userService;
            _mapper = mapper;
            _configuration = configuration;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserDTO userDto)
        {
            try
            {
                if (userDto == null || string.IsNullOrWhiteSpace(userDto.Email) || string.IsNullOrWhiteSpace(userDto.Password))
                {
                    return BadRequest("Invalid request data");
                }
                if (userDto.Mobile != null)
                {
                   bool val =_userService.isExist("Mobile", userDto.Mobile);
                    if(val==true)
                    return BadRequest("Mobile number exists");
                }
                if (userDto.Email != null)
                {
                    bool val = _userService.isExist("Email", userDto.Email);
                    if (val == true)
                        return BadRequest("Email exists");
                }
                await _userService.Register(userDto);
                return Ok(new { userDto });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ErrorMessage = ex.Message });
            }
        }
       
        // Controllers/AuthController.cs
      
        //[HttpPost("signIn")]
        //public async Task<IActionResult> SignIn([FromBody] UserDTO credentials)
        //{
        //    //if (credentials.Email == "a" && credentials.Password == "a")
        //    //{
        //    //    return Ok(new { Message = "Authentication successful" });
        //    //}
        //    //else
        //    //{
        //    //    return BadRequest(new { Message = "Invalid credentials", ErrorDetails = "Additional details about the error, if available" });
        //    //}
        //    var user = await _userService.SignIn(credentials.Email);

        //    if (user == null)
        //    {                     ````````````````````````````````````````````````````````````````````````````````````````````````````````````````````                                                                                                                                                                                                                                ````````````````````````````````````````````
        //        return Unauthorized("Invalid credentials");
        //    }

        //    return Ok(user);
        //    }


        [HttpPost("resetpassword")]

        public async Task<IActionResult> ResetPassword([FromBody] User request)
        {
            try
            {
                

                if (request == null || string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
                {
                    return BadRequest("Invalid request data");
                }
                var user = await _userService.GetUserByEmailAsync(request.Email);

                if (user == null)
                {
                    return NotFound("User not found");
                }
                var success=   await _userService.updatePasswordAsync(request);
                //return Ok(new { Message = "Password reset successful." });
                if (success)
                    return Ok(new { Message = "Password reset successfully." });
                return BadRequest("Invalid token or expired.");
            }
            catch (Exception ex)
            {
                return BadRequest(new { ErrorMessage = ex.Message });
            }
        }
        [Authorize]
        [HttpGet("userProfile")]
        public async Task<IActionResult> myaccount()
        {
            //try
            //{
            var email = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var user = await _userService.userProfile(email);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
          
        }
        [HttpPut("updateUser")]
        public async Task<IActionResult> updateUser( [FromBody] updateUserDTO userDTO)
        {
            try
            {
               // var users = await _userService.find(userDTO);
                var users = await _userService.updateAsync(userDTO);
                return Ok(new { Message = "updated successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ErrorMessage = ex.Message });
            }
        }

        [HttpPost("signin")]
        public IActionResult SignIn([FromBody] User signInRequest)
            {
            // Authenticate the user (replace this with your own authentication logic)
            if (_userService.IsValidUser(signInRequest.Email, signInRequest.Password))
            {
                // var token = _userService.GenerateToken(signInRequest.Email);
                var user = _userService.SignIn(signInRequest.Email);
                return Ok(new {user.Result });
                //return Ok(new { Token = user.token,signInRequest.Email });
            }
            return Unauthorized();
        }
    }
    



    
}
