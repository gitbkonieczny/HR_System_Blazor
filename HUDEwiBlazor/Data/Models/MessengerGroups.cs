using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using shortid;
using shortid.Configuration;
namespace HUDEwiBlazor.Data.Models
{
    public class MessengerGroups
    {
        public MessengerGroups()
        {
            var options = new GenerationOptions();
            options.UseNumbers = false;
            options.UseSpecialCharacters = false;
            options.Length = 14;
            this.GUID = ShortId.Generate(options) + "_" + DateTime.Now.Minute.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
        }
        [Key]
        public int groupID { get; set; }
        public string GUID { get; set; }
        public string Name { get; set; }
        public ICollection<LinkEmployeeMessengerGroup> Members { get; set; }
        public ICollection<Messages> Messages { get; set; }

    }
}
