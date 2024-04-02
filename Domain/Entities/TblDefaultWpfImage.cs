using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblDefaultWpfImage
    {
        public decimal DefaultImageId { get; set; }
        public byte[]? DefaultWpfImage { get; set; }
    }
}
