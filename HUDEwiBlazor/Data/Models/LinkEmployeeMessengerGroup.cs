using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class LinkEmployeeMessengerGroup
    {
        [Key]
        public int PLinkEmployeeMessengerGroup { get; set; }
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int? groupID { get; set; }
        public MessengerGroups MessengerGroups { get; set; }
    }
}
