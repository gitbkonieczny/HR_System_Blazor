using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Codes
    {
        [Key]
        public int? CodeID { get; set; }

        public string Code { get; set; }
        public string Description { get; set; }

        public ICollection<DayActions> DayActions { get; set; }
    }
}
