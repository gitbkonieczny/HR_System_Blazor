using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Data;
using HUDEwiBlazor.Data.Models;
using HUDEwiBlazor.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HUDEwiBlazor.Classes
{
    public class HolidayApiService:IHolidayApiService
    {
        private readonly ApplicationDBContext _context;
        public HolidayApiService(ApplicationDBContext context)
        {
            this._context = context;
        }
        public List<HolidaysApi> GetHolidaysObjects(DateTime Date, string language, string state)
        {
            var holiday = _context.HolidaysApi.Where(x => x.date.Date == Date.Date && x.country == language && (x.locations == state || x.locations == "All")).ToList();
            return holiday;
        }
        public async Task<List<string>> GetCountryList()
        {
            var list = await _context.HolidaysApi.Where(x => x.country != null).Select(o => o.country).Distinct().ToListAsync();
            return list;
        }

        public async Task<List<string>> GetCountryStateListAsync(string language)
        {
            var list = await _context.HolidaysApi.Where(x => x.locations != null && x.country == language).Select(o => o.locations).Distinct().ToListAsync();
            return list;
        }
        public List<string> GetCountryStateList(string language)
        {
            var list = _context.HolidaysApi.Where(x => x.locations != null && x.country == language).Select(o => o.locations).Distinct().ToList();
            return list;
        }
        
        public async Task<List<HolidaysApi>> GetAllCountryStateList()
        {
            var list = await _context.HolidaysApi.Where(x => x.locations != null).Distinct().ToListAsync();
            return list;
        }

        public async Task<HolidaysSet> GetHolidaySet(int emp_id, DateTime date)
        {
            return await _context.HolidaysSet.Where(x => (x.EmployeeID == emp_id) && (x.Year_int == date.Year)).FirstOrDefaultAsync();
        }

        public async Task<int> ConfirmedHolidayForNow(Employee emp, int Year)
        {
            var abs = await _context.DayActions.Where(x => x.EmployeeID == emp.EmployeeID && (x.CodeID == 27 || x.CodeID == 28) && x.Confirmed == true && x.FromDateID.Year == Year).ToListAsync();
            if (abs.Count() != 0)
            {
                int? used = 0;
                foreach (var item in abs)
                {
                    for (DateTime day = item.FromDateID; day <= item.ToDateID; day=day.AddDays(1))
                    {
                        var holiday = await _context.HolidaysApi.Where(x => x.date.Date == day.Date && x.country == emp.HolidayCountry && x.locations == emp.HolidayCountryState && (x.type == "National holiday" || x.type == "Common local holiday")).ToListAsync();
                        if (holiday.Count() > 0) continue;
                        if (day.DayOfWeek == DayOfWeek.Sunday || day.DayOfWeek == DayOfWeek.Saturday) continue;
                        used++;
                    }
                }
                return (int)(used);
            }
            else
            {
                return 0;
            }
        }



    }

    
}
