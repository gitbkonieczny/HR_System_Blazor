using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Teams
    {
        [Key]
        public int? TeamId { get; set; }
        public string TeamName { get; set; }
        public int? TeamLeaderID { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public string Users { get; set; }
        public Employee TeamLeader { get; set; }
        [NotMapped]
        public string TeamLeaderName { get; set; }

        public string ShiftOrder { get; set; }
        [NotMapped]
        public string ShiftName { get; set; }

        public int? ProjectID { get; set; }
        [NotMapped]
        public string ProjectName { get; set; }
        public Projects Projects { get; set; }
        public ICollection<LinkTeamsEmployee> LinkTeamsEmployee { get; set; }

    }
}
