using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSmtpemail
    {
        public int SmtpuserId { get; set; }
        public string? Smtpuser { get; set; }
        public string? Password { get; set; }
        public string? Smtphost { get; set; }
        public string? Smtpport { get; set; }
    }
}
