using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IUserService
    {
        Task<userProfileDTO> userProfile(string Email);
        Task<UserDTO> SignIn(string Email);
        Task<UserDTO> Register(UserDTO userDTO);
        Task<bool> updateAsync(updateUserDTO userDTO);
        Task<bool> updatePasswordAsync(User userCredentials);
        // Task DeleteAsync(TblPosuserDTO userDTO);
        Task<TblAccountLedger> GetByIdDecAsync(decimal id);
        Task<UserDTO> GetUserByEmailAsync(string Email);
        string GenerateToken(string username);
       bool IsValidUser(string email, string password);
        bool isExist(string parm,string  value);

        

    }

}
