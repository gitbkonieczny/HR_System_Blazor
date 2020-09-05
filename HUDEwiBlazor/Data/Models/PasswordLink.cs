using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class PasswordLink
    {
        [Key]
        public string Email { get; set; }
        public string Link { get; set; }
    }
}
