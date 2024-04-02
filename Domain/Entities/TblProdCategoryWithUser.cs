using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProdCategoryWithUser
    {
        public decimal CategoryUserId { get; set; }
        public decimal? GroupId { get; set; }
        public decimal? UserId { get; set; }
        public bool? IsActive { get; set; }
    }
}
