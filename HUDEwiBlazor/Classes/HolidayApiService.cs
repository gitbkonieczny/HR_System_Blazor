using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Data;
using HUDEwiBlazor.Data.Models;
using HUDEwiBlazor.Interfaces;

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
    }

    
}
