using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class HolidaysApi
    {
        public DateTime date { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string country { get; set; }
        public string locations { get; set; }

    }
}
