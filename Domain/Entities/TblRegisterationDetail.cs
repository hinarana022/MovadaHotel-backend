using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRegisterationDetail
    {
        public int DetailId { get; set; }
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public string? SubModuleId { get; set; }
        public string? OperatingSystem { get; set; }
        public DateTime? InstallationDate { get; set; }
        public string? Macid { get; set; }
        public string? MachineType { get; set; }
        public string? Message { get; set; }
    }
}
