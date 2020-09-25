using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class LinkRolesMenuItem
    {
        [Key]
        public int? LinkRolesMenuItemID { get; set; }
        public int? RoleID { get; set; }
        public int? MenuItemID { get; set; }

        public Roles Role { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
