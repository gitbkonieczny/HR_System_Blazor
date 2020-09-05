using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    


    public class Projects
    {
        [Key]
        public int? ProjectID { get; set; }
        public int? ProjectLeaderID { get; set; }
        public Employee ProjectLeader { get; set; }
        public int? deputyProjectLeaderID { get; set; }
        public Employee deputyProjectLeader { get; set; }

        [NotMapped]
        public string ProjectLeaderName { get; set; }
        [NotMapped]
        public string ProjectLeaderNameDeputy { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public string TeamsName { get; set; }
        [NotMapped]
        public string DepartmentName { get; set; }
        public ICollection<LinkProjectDepartment> LinkProjectDepartment { get; set; }
        public ICollection<Teams> Teams { get; set; }
        public ICollection<Shifts> Shifts { get; set; }
        public ICollection<OverTimesSimple> OverTimesSimple { get; set; }

    }
}
