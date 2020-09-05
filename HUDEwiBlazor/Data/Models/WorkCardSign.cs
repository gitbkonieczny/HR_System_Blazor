using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUDEwiBlazor.Data.Models
{
    public class WorkCardSign
    {
       
        public WorkCardSign(int? EmployeesID)
        {
            this.GenerateDate = DateTime.Now;
            this.Month = DateTime.Now.Month;
            this.Year = DateTime.Now.Year;
            this.EmployeesID = EmployeesID;
            this.Signed = false;
            this.Accepted = false;
            this.File = null;
            this.SignDate = null;
            this.AcceptedDate = null;
            this.Closed = false;
        }
        [Key]
        public string WorkCardSignID { get; set; }
        public DateTime? GenerateDate { get; set; }
        public int? EmployeesID { get; set; }
        public Employee employee { get; set; }
        [NotMapped]
        public string Name { get; set; }
        [NotMapped]
        public string Surname { get; set; }
        public int? Month { get; set; }
        [NotMapped]
        public string MonthFormated { get; set; }
        public int? Year { get; set; }
        [NotMapped]
        public string Description { get; set; }
        public bool? Signed { get; set; }
        public DateTime? SignDate { get; set; }
        public bool? Accepted { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public bool? Closed { get; set; }
        public byte[] File { get; set; }
    }
}
