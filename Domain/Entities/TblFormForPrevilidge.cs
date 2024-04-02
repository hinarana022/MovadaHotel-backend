using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblFormForPrevilidge
    {
        public int Id { get; set; }
        public string? ModuleName { get; set; }
        public string? FormName { get; set; }
    }
}
