using Application.DTOs;
using Application.Interface;
using Application.Interface.Custom;
using Application.Services.Custom;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService

    {
        //private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IRepository<TblAccountLedger> _repository;
        private readonly dbHMSContext _dbContext;
        private readonly IConfiguration _configuration;

        public UserService(IRepository<TblAccountLedger> repository, IMapper mapper, dbHMSContext dbContext, IConfiguration configuration)
        {
            _repository = repository;
            _mapper = mapper;
            _dbContext = dbContext;
            _configuration = configuration;

        }
        public async Task<userProfileDTO> userProfile(string email)
        {
            var user = await _dbContext.TblAccountLedgers.Where(x=>x.Email==email).FirstOrDefaultAsync();
            if (user!=null)
            {
                var userbookings = await GetAllAsync(Convert.ToInt32(user.LedgerId)).ToListAsync();
                var userimage = await _dbContext.TblVoucherAttachments.Where(x => x.VoucherNo == user.LedgerId.ToString()).FirstOrDefaultAsync(); ;
                var userdto = _mapper.Map<userProfileDTO>(user);
                userdto.tblbookinglist = userbookings;
                userdto.tblVoucherAttachment = userimage;
                return userdto;
                
            }
            return null;
        }


        public async Task<UserDTO> Register(UserDTO userDto)
        {
            
            userDto.LedgerId = GetMaxLedgerId();
            userDto.LedgerCode = GetMaxLedgerCode();
            var user = _mapper.Map<TblAccountLedger>(userDto);
            user.AccountGroupId =26;
            user.Status =true ;
            user.Route = "1";
            await _repository.AddAsync(user);
            return userDto;
        }

        public async Task<bool> updateAsync(updateUserDTO userDto)
        {
            var user = await _dbContext.TblAccountLedgers.FirstOrDefaultAsync(a => a.LedgerId == userDto.LedgerId);
            if (user != null)
            {
                user.LedgerName = userDto.LedgerName;
                if (userDto.Email != "")
                    user.Email = userDto.Email;
                if (userDto.Password != "")
                    user.Password = userDto.Password;
                if (userDto.Mobile != null)
                    user.Mobile= userDto.Mobile;
            }
            //var user = _mapper.Map<TblAccountLedger>(userDto);
            // var updateduser = await _dbContext.TblAccountLedgers.Update(user);
            await _repository.UpdateAsync(user);
            return true;
        }



        public async Task<UserDTO> SignIn(string Email)
        {
            var token = GenerateToken(Email);

            var signedInUser = await _dbContext.TblAccountLedgers.FirstOrDefaultAsync(a => a.Email == Email);
            var userDTO = _mapper.Map<UserDTO>(signedInUser);
            userDTO.token = token;
            return userDTO;
        }
        public decimal GetMaxLedgerId()
        {
            var maxId = _dbContext.TblAccountLedgers
                .Max(entity => entity.LedgerId);
            return maxId+1;
        }
        public string GetMaxLedgerCode()
        {
            var maxLedgerCode = _dbContext.TblAccountLedgers
                .Max(entity => entity.LedgerCode);
            return (Convert.ToDecimal( maxLedgerCode)+1).ToString();
        }
        public IQueryable<TblRoomBookingMasterDTO> GetAllAsync(int id)
        {
            var query =from t1 in _dbContext.TblRoomBookingMasters
                       join t2 in _dbContext.TblRoomTypeMasters on t1.RoomId equals t2.RoomTypeId
                       join t3 in _dbContext.TblRoomTypeImages on t1.RoomTypeId equals Convert.ToInt32(t3.RoomTypeId)
                       where t1.LedgerId == id

                        select new TblRoomBookingMasterDTO
                        {
                            ReservationStatus = t1.ReservationStatus,
                            ReservationDate = t1.ReservationDate,
                            ReservationTime = t1.ReservationTime,
                            ArrivalDate = t1.ArrivalDate,
                            ArrivalTime = t1.ArrivalTime,
                            DepartureDate = t1.DepartureDate,
                            guests = Convert.ToInt32(t1.NoOfAdults + t1.NoOfChilds),
                            GrandTotal = t1.GrandTotal,
                            ReservationNo = t1.ReservationNo,
                            RoomTypeName = t2.RoomTypeName,
                            tblRoomTypeImage = t3

                        };
            return query;
        }

        public Task<TblAccountLedger> GetByIdDecAsync(decimal id)
        {
            var user = _repository.GetByIdDecAsync(id);
            return user;

        }

        public async Task<UserDTO> GetUserByEmailAsync(string Email)
        {
            var signedInUser = await _dbContext.TblAccountLedgers.FirstOrDefaultAsync(a => a.Email == Email);
            var userDTO = _mapper.Map<UserDTO>(signedInUser);
            return userDTO;

        }

        public async Task<bool> updatePasswordAsync(User userCredentials)
        {
            var user = await _dbContext.TblAccountLedgers.FirstOrDefaultAsync(a => a.Email == userCredentials.Email);
            if (user != null)
            {
                if (userCredentials.Password != "")
                    user.Password = userCredentials.Password;

            }
            //var user = _mapper.Map<TblAccountLedger>(userDto);
            // var updateduser = await _dbContext.TblAccountLedgers.Update(user);
            await _repository.UpdateAsync(user);
            return true;
        }


        //private string GenerateToken1(string privatekey)
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        //    var credientials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        //    var claims = new[]
        //    {
        //        new Claim(JwtRegisteredClaimNames.Sub,privatekey),
        //        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
        //    };

        //    var token = new JwtSecurityToken(
        //        issuer: _configuration["Jwt:Issuer"],
        //        audience: _configuration["Jwt:Issuer"],
        //        claims,
        //        expires: DateTime.Now.AddYears(1),
        //        signingCredentials: credientials
        //        );
        //    var encodedtoken = new JwtSecurityTokenHandler().WriteToken(token);
        //    return encodedtoken.ToString();
        //}

        private bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            // You should implement password hashing and comparison logic here
            // For simplicity, this example assumes plain text passwords
            return enteredPassword == hashedPassword;
        }


        public bool IsValidUser(string email, string password)
        {
            var user = _dbContext.TblAccountLedgers.FirstOrDefault(u => u.Email == email);

            // Check if the user exists and the password matches
            if (user != null && VerifyPassword(password, user.Password))
            {
                return true;
            }
            return false;
        }

      
        public string GenerateToken(string privatekey)
        {

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credientials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,privatekey),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddYears(1),
                signingCredentials: credientials
                );
            var encodedtoken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodedtoken.ToString();
        }

        public bool isExist(string parm,string value)
        {
            if (parm == "Mobile")
            {
                var parmval = _dbContext.TblAccountLedgers.Where(x => x.Mobile == value).Select(x => x.Mobile).FirstOrDefault();
                if (parmval != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (parm == "Email")
            {
                var parmval = _dbContext.TblAccountLedgers.Where(x => x.Email == value).Select(x => x.Email).FirstOrDefault();
                if (parmval != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}