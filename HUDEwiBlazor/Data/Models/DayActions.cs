using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class DayActions
    {
        [Key]
        public int? DayActionsID { get; set; }
        public DateTime SubmissionDate { get; set; }
        [NotMapped]
        public string SubmissionDateFormated { get; set; }
        [Required]
        [Column("Employee")]
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }
        [NotMapped]
        public string EmployeeName { get; set; }
        [NotMapped]
        public string FromMonthName { get; set; }
        [NotMapped]
        public string ToMonthName { get; set; }
        [Required]
        [Column("FromDateID")]
        public DateTime FromDateID { get; set; }
        [NotMapped]
        public string FromDateFormated { get; set; }
        [Required]
        [Column("ToDateID")]
        public DateTime ToDateID { get; set; }
        [NotMapped]
        public string ToDateFormated { get; set; }
        public bool? Confirmed { get; set; } //null-to accept wait or reject, true-accepted, false - rejected
        public int? ConfirmedBy { get; set; }
        [NotMapped]
        public string ConfirmedByName { get; set; }
        [Required]
        [Column("Code")]
        public int? CodeID { get; set; }
        public Codes Codes { get; set; }
        [NotMapped]
        public string CodeName { get; set; }
        [NotMapped]
        public string CodeShortName { get; set; }
        public int? EventID { get; set; }
        public HolidayEventsList HolidayEventsList { get; set; }
        [NotMapped]
        public string HolidayEventsListName { get; set; }
        public int? ChildID { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Description { get; set; }

        public string FromShift { get; set; }
        public string ToShift { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
        public bool ShowOnCard { get; set; } = false;
        public string ScheduleColor { get; set; } = "#ffffff";
    }
}
