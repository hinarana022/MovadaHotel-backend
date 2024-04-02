using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRegisterationLogAttempt
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string RegisterationKey { get; set; } = null!;
        public string ApplicationKey { get; set; } = null!;
        public string Macid { get; set; } = null!;
        public DateTime InstallationDate { get; set; }
        public string MachineType { get; set; } = null!;
        public string SubModuleId { get; set; } = null!;
    }
}
