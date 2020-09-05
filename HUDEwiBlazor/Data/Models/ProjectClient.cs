using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class ProjectClient
    {
        [Key]
        public int? ProjectClientID { get; set; }
        [Required]
        public int? ClientID { get; set; }
        public Client Client { get; set; }
        [Required]
        public int? ProjectID { get; set; }
        public Projects Projects { get; set; }
    }
}
