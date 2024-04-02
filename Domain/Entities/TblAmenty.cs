using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class TblAmenty
    {
        public decimal AmentiesId { get; set; }
        public string? AmentiesName { get; set; }
        public string? Narration { get; set; }
        public bool? Isactive { get; set; }
        [NotMapped]
        public TblAmentiesImage TblAmentiesImage { get; set; }
    }
}
