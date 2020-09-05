using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class LinkEmployeRoles
    {
        [Key]
        public int? EmployeRolesID { get; set; }
        public int? EmployeeID { get; set; }
        public int? RolesID { get; set; }

        public Employee Employee { get; set; }
        public Roles Roles { get; set; }
    }

}
