using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Classes.Mapped
{
    public class MappedEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalNumber { get; set; }
        public string ShortCut { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthDateFormated { get; set; }
        public int? Gender { get; set; }
        public string GenderName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public bool Active { get; set; }
        public string HolidayCountry { get; set; }
        public string HolidayCountryState { get; set; }
        public string Roles { get; set; }
        public string ProjectsNames { get; set; }

        public byte[] Avatar { get; set; }
        public string Avatar64
        {
            get
            {
                if (Avatar != null)
                {
                    return System.Convert.ToBase64String(Avatar);
                }
                else
                    return null;

            }
        }
        public int[] RolesID { get; set; }
    }
}
