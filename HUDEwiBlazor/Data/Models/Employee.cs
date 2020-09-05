using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class Employee
    {

        public Employee()
        {
            Gender = 0;
            MobileNo = "brak";
            PReset = false;
            PersonalNumber = "";
            ShortCut = "";
        }
        public Employee(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        [Key]
        public int? EmployeeID { get; set; }
        public string? GUID { get; set; }

        [MinLength(3)]
        [Required]
        public string Name { get; set; }

        [MinLength(3)]
        [Required]
        public string Surname { get; set; }

        public string PersonalNumber { get; set; }
        public string ShortCut { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Valid Date is Required")]
        public DateTime BirthDate { get; set; }


        public int Gender { get; set; }
        [NotMapped]
        public string GenderName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Phone]
        public string MobileNo { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public byte[] Salt { get; set; }

        public bool Active { get; set; }
        public bool PReset { get; set; }


        public string HolidayCountry { get; set; }
        public string HolidayCountryState { get; set; }

        [NotMapped]
        public string Roles { get; set; }

        [NotMapped]
        public string ProjectsNames { get; set; }

        [NotMapped]
        public string Token { get; set; }

        public byte[] Avatar { get; set; }

        public string DeviceToken { get; set; }

        public bool? ForcePasswordChange { get; set; }
        public ICollection<LinkTeamsEmployee> LinkTeamsEmployee { get; set; }

        public ICollection<Teams> Teams { get; set; }
        public ICollection<Messages> MessagesFrom { get; set; }
        public ICollection<Messages> MessagesTo { get; set; }

        public ICollection<Projects> Projects { get; set; }
        public ICollection<Projects> ProjectsDeputy { get; set; }


        public ICollection<LinkLeaderDepartment> LinkLeaderDepartment { get; set; }
        public ICollection<LinkEmployeRoles> LinkEmployeRoles { get; set; }
        public ICollection<LinkEmployeeMessengerGroup> LinkEmployeeMessengerGroup { get; set; }

        public ICollection<WorkCardSign> WorkCardSigns { get; set; }
        public ICollection<OverTimesSimple> OverTimesSimple { get; set; }
        public ICollection<Tokens> Tokens { get; set; }
        public ICollection<Schedules> Schedules { get; set; }
        public ICollection<HolidaysSet> HolidaysSet { get; set; }

        [NotMapped]
        public int? HolidaysMax { get; set; }
        [NotMapped]
        public int? HolidaysOnDemandMax { get; set; }

        public int? SessionTime { get; set; }
    }
}
