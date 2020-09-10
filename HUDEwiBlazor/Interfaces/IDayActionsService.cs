using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Classes;
using HUDEwiBlazor.Data.Models;

namespace HUDEwiBlazor.Interfaces
{
    public interface IDayActionsService
    {
        List<DayActionGridList> GetDayActionsRangeForEmployeeWithCodes(Employee emp, List<int?> CodeID, List<DateTime> daterange, string format);
        Task<bool> ConfirmDayFromCallendar(DateTime date, Employee employee);
    }
}
