using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class LinkTeamsEmployee
    {
        [Key]
        public int? PLinkTeamsEmployee { get; set; }
        public int? TeamId { get; set; }
        public Teams Teams { get; set; }
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }

    }
}
