using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Tokens
    {
        [Key]
        public int? TokenID { get; set; }
        public int? EmployeesID { get; set; }
        public Employee employee { get; set; }
        public string Token { get; set; }
    }
}
