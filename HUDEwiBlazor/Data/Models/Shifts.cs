using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Shifts
    {
        [Key]
        public int? ShiftID { get; set; }

        public string Name { get; set; }

        public TimeSpan From { get; set; }

        [NotMapped]
        public string FromFormated { get; set; }


        public TimeSpan To { get; set; }

        [NotMapped]
        public string ToFormated { get; set; }

        public int? ProjectID { get; set; }
        [NotMapped]
        public string ProjectName { get; set; }
        public Projects Projects { get; set; }
        public string Description { get; set; }

        public ICollection<Schedules> Schedules { get; set; }

        public ICollection<Teams> Teams { get; set; }
    }

}
