using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblCashReceived
    {
        public int Id { get; set; }
        public int Currencyid { get; set; }
        public int Amount { get; set; }
        public int Fromuser { get; set; }
        public int Masterid { get; set; }
        public int Uid { get; set; }
        public DateTime Datetime { get; set; }
        public int Value { get; set; }
    }
}
