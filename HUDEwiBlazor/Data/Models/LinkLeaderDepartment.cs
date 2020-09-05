using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class LinkLeaderDepartment
    {
        [Key]
        public int? PLinkLeaderDepartmentID { get; set; }
        public int? DepartmentID { get; set; }
        public Departments Departments { get; set; }
        public int? LeaderID { get; set; }
        public Employee Employee { get; set; }
    }
}
