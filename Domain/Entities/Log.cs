using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Log
    {
        public long Id { get; set; }
        public string Message { get; set; } = null!;
    }
}
