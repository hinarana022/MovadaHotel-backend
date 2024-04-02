using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string? LedgerName { get; set; }
        public decimal? LedgerId { get; set; }  
        public string? Mobile { get; set; }
        public string? LedgerCode { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? token { get; set; }
        //account ledger
        //public decimal LedgerId { get; set; }
        //public string? LedgerName { get; set; }
        //public string? Mobile { get; set; }
        //[Required]
        //[EmailAddress]
        //public string? Email { get; set; }
        //public string? Password { get; set; }
        //public string? ConfirmPassword { get; set; }
    }
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class updateUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string? LedgerName { get; set; }
        public int? LedgerId { get; set; }
        public string? Mobile { get; set; }
    }
}
