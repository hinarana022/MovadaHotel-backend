using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblRegisterationSubModuleDetail
    {
        public int SubModuleDetailId { get; set; }
        public int Id { get; set; }
        public int SubModuleId { get; set; }
        public string SubModuleName { get; set; } = null!;
        public string NoOfMachines { get; set; } = null!;
    }
}
