using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblUser
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? UserType { get; set; }
    }
}
