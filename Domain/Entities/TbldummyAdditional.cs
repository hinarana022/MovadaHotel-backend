using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TbldummyAdditional
    {
        public int Stockid { get; set; }
        public int Productid { get; set; }
        public int Qty { get; set; }
        public int? Imei { get; set; }
        public int? Color { get; set; }
        public int? Model { get; set; }
        public int? Extrakey1 { get; set; }
        public int? Extrakey2 { get; set; }
    }
}
