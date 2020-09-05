using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Navigation
    {
        [Key]
        public int nodeId { get; set; }
        public string nodeText { get; set; }
        public string iconCss { get; set; }
        public string link { get; set; }

        public string controller { get; set; }
        public string action { get; set; }
        public string childs { get; set; }
    }
}
