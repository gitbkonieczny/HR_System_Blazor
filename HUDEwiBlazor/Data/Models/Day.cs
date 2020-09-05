using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Day
    {
        [Key]
        public int DayID { get; set; }
        [StringLength(30)]
        public string DayName { get; set; }

        //public ICollection<Calendar> Calendars { get; set; }
    }
}
