using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Calendar
    {
        [Key]
        public DateTime DateID { get; set; }
        public int? DayOfMonth { get; set; }
        public int? Year { get; set; }
        public int? QuarterOfYear { get; set; }
        public int? DayOfQuarter { get; set; }
        public int? DayofYear { get; set; }
        public int? WeekOfMonth { get; set; }
        public int? WeekOfQuarter { get; set; }
        public int? BillingPeriod { get; set; }
        public int? DayOfBillingPeriod { get; set; }
        public int? WeekOfBillingPeriod { get; set; }
        public int? WorkingWeekOfYear { get; set; }
        public bool? IsHoliday { get; set; }
        //public enum 

        public int? DayID { get; set; }
        public Day Day { get; set; }

        public int? MonthID { get; set; }
        public Month Month { get; set; }

        [NotMapped]
        public bool Saturday_emp { get; set; }
        [NotMapped]
        public bool Sunday_emp { get; set; }
        [NotMapped]
        public bool Holiday_emp { get; set; }
    }
}
