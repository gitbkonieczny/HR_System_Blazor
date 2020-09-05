using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class HolidaysSet
    {
        [Key]
        public int? HolidaysSetID { get; set; }

        [Required]
        [Column("Employee")]
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public int Year_int { get; set; }

        public int? HolidaysMax { get; set; }
        public int? HolidaysGet { get; set; }
        //int? HolidaysLeft { get; set; } Max - Get
        public int? HolidaysOnDemandMax { get; set; }
        public int? HolidaysOnDemandGet { get; set; }
    }
}
