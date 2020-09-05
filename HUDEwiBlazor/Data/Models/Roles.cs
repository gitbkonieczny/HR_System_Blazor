using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Roles
    {
        [Key]
        public int? RolesID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public string Users { get; set; }
        public ICollection<LinkEmployeRoles> LinkEmployeRoles { get; set; }

    }
}
