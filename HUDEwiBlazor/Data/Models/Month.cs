using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Month
    {
        [Key]
        public int MonthID { get; set; }
        [StringLength(30)]
        public string MonthName { get; set; }

        //public ICollection<Calendar> Calendars { get; set; }
    }
}
