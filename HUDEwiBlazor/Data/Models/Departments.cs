using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Departments
    {
        [Key]
        public int? DepartmentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public string LeadersName { get; set; }

        [NotMapped]
        public string Projects { get; set; }

        public ICollection<LinkProjectDepartment> LinkProjectDepartment { get; set; }
        public ICollection<LinkLeaderDepartment> LinkLeaderDepartment { get; set; }
    }
}
