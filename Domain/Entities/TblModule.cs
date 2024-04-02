using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblModule
    {
        public int Id { get; set; }
        public string? ModuleName { get; set; }
        public string? ModuleUnder { get; set; }
    }
}
