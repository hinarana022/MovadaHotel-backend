using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSmsapiSetting
    {
        public int Apiid { get; set; }
        public string? Apiname { get; set; }
        public string? ApIurl { get; set; }
        public string? UsernameVariable { get; set; }
        public string? UsernameValue { get; set; }
        public string? PasswordVariable { get; set; }
        public string? PasswordValue { get; set; }
        public string? DestinationVariable { get; set; }
        public string? MessageVariable { get; set; }
        public string? SuccessCode { get; set; }
        public string? CompanyName { get; set; }
        public string? ApikeyVariable { get; set; }
        public string? Apikey { get; set; }
        public string? SenderVariable { get; set; }
    }
}
