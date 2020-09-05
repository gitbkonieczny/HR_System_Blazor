using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class PasswordOptions
    {
        public int RequiredLength { get; set; }
        public int RequiredUniqueChars { get; set; }
        public bool RequireDigit { get; set; }
        public bool RequireLowercase { get; set; }
        public bool RequireNonAlphanumeric { get; set; }
        public bool RequireUppercase { get; set; }
        public string Secret { get; set; }

    }

}
