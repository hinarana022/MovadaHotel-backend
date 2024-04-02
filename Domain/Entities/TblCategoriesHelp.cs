using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCategoriesHelp
    {
        public int Id { get; set; }
        public decimal GroupId { get; set; }
        public string? GroupName { get; set; }
        public decimal? GroupUnder { get; set; }
        public string? Narration { get; set; }
        public string? GroupNamehelp { get; set; }
    }
}
