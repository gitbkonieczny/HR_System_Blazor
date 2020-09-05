using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class ParentHoliday
    {
        [Key]
        public int? ParentHolidayID { get; set; }
        [Required]
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int? CountHoliday { get; set; }

        [Required]
        public DateTime Year { get; set; }

    }
}
