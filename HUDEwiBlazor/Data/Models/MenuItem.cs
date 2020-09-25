using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Text { get; set; }
        public string IconCss { get; set; }
        public string Url { get; set; }
        public int? ParentID { get; set; }
        public bool Invisible { get; set; }
        public virtual MenuItem Parent { get; set; }
        public virtual ICollection<MenuItem> Items { get; set; }
        public ICollection<LinkRolesMenuItem> LinkRolesMenuItem { get; set; }

    }
}
