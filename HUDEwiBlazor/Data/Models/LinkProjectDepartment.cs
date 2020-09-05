using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class LinkProjectDepartment
    {
        [Key]
        public int? PLinkProjectDepartmentID { get; set; }
        public int? DepartmentID { get; set; }
        public Departments Departments { get; set; }
        public int? ProjectID { get; set; }
        public Projects Projects { get; set; }
    }
}
