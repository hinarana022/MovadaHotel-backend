using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblReminder
    {
        public decimal ReminderId { get; set; }
        public DateTime? ReminderDate { get; set; }
        public TimeSpan? ReminderTime { get; set; }
        public string? Reminder { get; set; }
        public string? Details { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
    }
}
