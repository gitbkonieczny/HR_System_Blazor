using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Messages
    {
        [Key]
        public long messageId { get; set; }
        public bool group_message { get; set; }
        public int? FromEmployee { get; set; }
        public Employee FromEmployeeObj { get; set; }
        public int? ToGroup { get; set; }
        public MessengerGroups ToGroupObj { get; set; }
        public int? ToEmployee { get; set; }
        public Employee ToEmployeeObj { get; set; }

        public string Message { get; set; }
    }
}
