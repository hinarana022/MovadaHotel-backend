using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblSmssetting
    {
        public decimal SmsSettingId { get; set; }
        public decimal? ReminderBeforeDays { get; set; }
        public string? DefaultReminderTemplate { get; set; }
        public decimal? NoOfRemindAfterDueDate { get; set; }
        public string? DefaultAfterDueDate { get; set; }
        public string? PortNo { get; set; }
        public string? DefaultMobileNo { get; set; }
        public string? DelayTime { get; set; }
    }
}
