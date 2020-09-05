using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class OverTimesSimple
    {

        [Key]
        public int? OverTimeID { get; set; }
        public int? EmployeesID { get; set; }
        public Employee employee { get; set; }
        [NotMapped]
        public string EmployeeName { get; set; }
        public int? ProjectID { get; set; }
        [NotMapped]
        public string ProjectName { get; set; }
        public Projects Projects { get; set; }

        public int? TeamId { get; set; }
        [NotMapped]
        public string TeamName { get; set; }
        public Teams Teams { get; set; }

        [NotMapped]
        public string Month { get; set; }
        public DateTime DateID { get; set; }


        public int? getMonthInt()
        {
            return DateID.Date.Month;

        }
        public int? getYearInt()
        {
            return DateID.Date.Year;
        }

        [NotMapped]
        public string DateFormated { get; set; }
        [NotMapped]
        public TimeSpan From { get; set; }
        [NotMapped]
        public TimeSpan To { get; set; }
        public bool SapOvertime { get; set; }
        public string PaidPercent { get; set; }
        public bool? Confirmed { get; set; } //null-to accept wait or reject, true-accepted, false - rejected
        public int? ConfirmedBy { get; set; }
        [NotMapped]
        public string ConfirmedByName { get; set; }
        public string Description { get; set; }
        public string ToolTip { get; set; }

        public Int64 FromValueTicks { get; set; }
        public Int64 ToValueTicks { get; set; }
        [NotMapped]
        public TimeSpan FromValue
        {
            get { return TimeSpan.FromMinutes(FromValueTicks); }
            set { FromValueTicks = (int)value.TotalMinutes; }
        }

        [NotMapped]
        public TimeSpan ToValue
        {
            get { return TimeSpan.FromMinutes(ToValueTicks); }
            set { ToValueTicks = (int)value.TotalMinutes; }
        }
        [NotMapped]
        public string? OverTimeTypeName { get; set; }
        [NotMapped]
        public string? OverTimeTypeColor { get; set; }

        public int? OverTimeTypesId { get; set; }
        public OverTimeTypes OverTimeTypes { get; set; }
        [NotMapped]
        public bool adminoverride { get; set; }
    }
}
