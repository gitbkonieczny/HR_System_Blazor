using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class OverTimeTypes
    {
        [Key]
        public int? OverTimeTypesId { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }
        public ICollection<OverTimesSimple> OverTimesSimple { get; set; }
    }
}
