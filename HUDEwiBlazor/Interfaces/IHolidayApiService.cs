using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Data.Models;

namespace HUDEwiBlazor.Interfaces
{
    public interface IHolidayApiService
    {
        List<HolidaysApi> GetHolidaysObjects(DateTime Date, string language, string state);
        Task<List<string>> GetCountryList();
        Task<List<string>> GetCountryStateListAsync(string language);
        List<string> GetCountryStateList(string language);
        Task<List<HolidaysApi>> GetAllCountryStateList();
        Task<HolidaysSet> GetHolidaySet(int emp_id, DateTime date);
        Task<int> ConfirmedHolidayForNow(Employee emp, int Year);
    }
}
