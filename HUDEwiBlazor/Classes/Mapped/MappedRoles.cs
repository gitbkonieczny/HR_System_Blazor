using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Classes.Mapped
{
    public class MappedRoles
    {
      
        public int? RolesID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
     
        public int[] UsersID { get; set; }
       
        public string Users { get; set; }
       
        public int[] MenusID { get; set; }
    }
}
