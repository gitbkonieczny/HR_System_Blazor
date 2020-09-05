using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Schedules
    {
        [Key]
        public int? ScheduleID { get; set; }
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }
        [NotMapped]
        public string EmployeeName { get; set; }
        public DateTime ScheduleDate { get; set; }
        public int? ShiftID { get; set; }
        public Shifts Shifts { get; set; }
        [NotMapped]
        public string ShiftName { get; set; }
        public string ScheduleColor { get; set; }
        public bool isoverride { get; set; } = false;
        public TimeSpan From { get; set; }
        [NotMapped]
        public string FromFormated { get; set; }
        public TimeSpan To { get; set; }
        [NotMapped]
        public string ToFormated { get; set; }
    }

}
