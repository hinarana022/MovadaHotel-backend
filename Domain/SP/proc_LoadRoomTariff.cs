using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SP
{
    public class proc_LoadRoomTariff
    {
        public decimal Tariff { get; set; }
        public string ExtraAdult { get; set; } // Change data type to decimal
        public string ExtraChild { get; set; } // Change data type to decimal
        public string BaseAdult { get; set; } // Change data type to decimal
        public string BaseChild { get; set; } // Change data type to decimal
    
}
    
}
