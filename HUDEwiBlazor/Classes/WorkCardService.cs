using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Data;
using HUDEwiBlazor.Data.Models;
using HUDEwiBlazor.Interfaces;

namespace HUDEwiBlazor.Classes
{
    public class WorkCardService: IWorkCardService
    {
        private readonly ApplicationDBContext _context;
        public WorkCardService(ApplicationDBContext context)
        {
            this._context = context;
        }

        public bool? CheckIfMonthClosed(Employee emp, int Month, int Year)
        {
            var workcard = _context.WorkCardSign.Where(x => x.EmployeesID == emp.EmployeeID && x.Month == Month && x.Year == Year);
            if (workcard.Count()!=0)
            {
                return workcard.First().Closed;
            }
            return null;
        }
    }
}
