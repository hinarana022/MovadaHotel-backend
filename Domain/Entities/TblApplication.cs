using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblApplication
    {
        public int Id { get; set; }
        public string ApplicationName { get; set; } = null!;
        public string? ApplicationKey { get; set; }
        public string? DefaultServerPath { get; set; }
    }
}
