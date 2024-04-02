using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSuffixPrefix
    {
        public int SuffixprefixId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? VocherType { get; set; }
        public string? Prefix { get; set; }
        public string? Suffix { get; set; }
        public string? StartIndex { get; set; }
        public string? WidthNumericalPart { get; set; }
        public string? Narattion { get; set; }
        public bool? IsPrifixZero { get; set; }
    }
}
