using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblImage
    {
        public decimal? CompanyId { get; set; }
        public byte[]? CompanyLogo { get; set; }
    }
}
