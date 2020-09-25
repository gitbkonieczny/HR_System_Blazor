using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Classes.Mapped
{
    public class MappedMenuItem
    {
        public int MenuItemId { get; set; }
        public string Text { get; set; }
        public string IconCss { get; set; }
        public string Url { get; set; }
        public int? ParentID { get; set; }
        public bool Invisible { get; set; }
    }
}
