using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Client
    {
        [Key]
        public int? ClientID { get; set; }
        [Required]
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Nip { get; set; }
        public string Regon { get; set; }
        public string KRS { get; set; }
        public string Voivodeship { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        [NotMapped]
        public string ProjectList { get; set; }
    }
}
