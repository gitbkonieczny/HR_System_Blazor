using System;
using System.Collections.Generic;
using HUDEwiBlazor.Classes;
using HUDEwiBlazor.Data.Models;

namespace HUDEwiBlazor.Interfaces
{
    public interface IScheduleService
    {
        List<SimpleScheduleModel> SimpleScheduleWithOverTimes(Employee emp, List<DateTime> Days);
        bool DayAttendancBlockLimit(int count, DateTime confirm_date, Employee employee);
    }
}
