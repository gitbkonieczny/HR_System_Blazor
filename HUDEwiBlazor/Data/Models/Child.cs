using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Child
    {
        [Key]
        public int? ChildID { get; set; }
        public string ChildName { get; set; }
        public DateTime ChildBorn { get; set; }
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }
        [NotMapped]
        public string EmployeeNameFormated { get; set; }
    }
}
