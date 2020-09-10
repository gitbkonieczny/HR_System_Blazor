using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class SystemSettings
    {
        public int OverTimeMaxPerYear { get; set; }
        public int OverTimeMaxPerWeek { get; set; }
        public int OverTimeMaxPerDay { get; set; }
        public int OverTimePay50PerWeek { get; set; }
        public int RestPeriod { get; set; }
        public int AttendanceReminderLimit { get; set; }
        public int ScheduleGenerateDays { get; set; }
        public int HolidaysMaxPerYear { get; set; }
        public int HolidaysOnDemandMaxPerYear { get; set; }
        public int DayTimeStartHour { get; set; }
        public int DayTimeStartMinutes { get; set; }
        public int DayTimeEndHour { get; set; }
        public int DayTimeEndMinutes { get; set; }
        public string BookingEmail { get; set; }
        public string ServerIP { get; set; }
        public string ServerPort { get; set; }
    }
}
