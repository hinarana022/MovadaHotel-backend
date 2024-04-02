using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblUserPrevilige
    {
        public int Id { get; set; }
        public string? ModuleForm { get; set; }
        public string? Description { get; set; }
    }
}
