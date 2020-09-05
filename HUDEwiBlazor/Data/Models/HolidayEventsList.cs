using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class HolidayEventsList
    {
        [Key]
        public int? EventID { get; set; }
        public int? Count { get; set; }
        public string Description { get; set; }
        public ICollection<DayActions> DayActions { get; set; }
    }
}
