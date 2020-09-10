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
    }
}
