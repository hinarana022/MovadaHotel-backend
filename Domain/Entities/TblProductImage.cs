using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblProductImage
    {
        public decimal ProductImageId { get; set; }
        public string? ProductId { get; set; }
        public string? Path { get; set; }
        public string? Description { get; set; }
        public byte[]? ProductImage { get; set; }
    }
}
