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
    public class ScheduleService:IScheduleService
    {
        private readonly ApplicationDBContext _context;
        private IHolidayApiService _holidayApiService;
        public ScheduleService(ApplicationDBContext context, IHolidayApiService holidayApiService)
        {
            this._context = context;
            this._holidayApiService = holidayApiService;
        }
        public List<SimpleScheduleModel> SimpleScheduleWithOverTimes(Employee emp, List<DateTime> Days)
        {
            var simpleschedule = new List<SimpleScheduleModel>();
            foreach (var day in Days)
            {
                var ftl = new List<FromTo>();
                var dayschedule = new SimpleScheduleModel();
                var schedule = _context.Schedules.Include(x => x.Shifts).Where(x => x.EmployeeID == emp.EmployeeID && x.ScheduleDate.Date == day.Date).FirstOrDefault();
                var ft = new FromTo();
                if (schedule != null)
                {
                    if (schedule.isoverride == true)
                    {
                        ft.From = schedule.From;
                        ft.To = schedule.To;

                        dayschedule.ShiftName = "Inne / Nadgodziny";

                        ftl.Add(ft);
                    }
                    else
                    {
                        ft.From = schedule.Shifts.From;
                        ft.To = schedule.Shifts.To;
                        dayschedule.ShiftName = schedule.Shifts.Name;
                        ftl.Add(ft);
                    }
                    dayschedule.ScheduleColor = schedule.ScheduleColor;
                }

                var overtimes = _context.OverTimesSimple.Where(x => x.EmployeesID == emp.EmployeeID && x.DateID.Date == day.Date).ToList();
                foreach (var over in overtimes)
                {
                    ft = new FromTo();
                    ft.From = over.FromValue;
                    ft.To = over.ToValue;
                    ftl.Add(ft);
                }

                if (ftl.Count() != 0)
                {
                    var orderedftl = ftl.OrderBy(x => x.From).ToList();
                    dayschedule.Date = day;
                    dayschedule.DateFormated = day.ToString("dd-MM-yyyy");
                    dayschedule.FromFormated = orderedftl.First().From.ToString(@"hh\:mm");
                    dayschedule.ToFormated = orderedftl.Last().To.ToString(@"hh\:mm");
                    dayschedule.From = orderedftl.First().From;
                    dayschedule.To = orderedftl.Last().To;

                    var absence = _context.DayActions.Where(x => x.EmployeeID == emp.EmployeeID && (x.Codes.Code == "PRA" || x.Codes.Code == "PRAT" || x.Codes.Code == "PRAN") && x.FromDateID.Date == day.Date).FirstOrDefault();
                    if (absence != null)
                    {
                        if (absence.EmployeeID != null) dayschedule.Confirmed = true;
                        if (absence.EmployeeID != null) dayschedule.ConfirmedBy = absence.EmployeeID;
                        if (absence.EmployeeID != null) dayschedule.ConfirmedByName = _context.Employees.Where(x => x.EmployeeID == absence.EmployeeID).FirstOrDefault().Name + " " + _context.Employees.Where(x => x.EmployeeID == absence.EmployeeID).FirstOrDefault().Surname;
                    }
                    else
                    {
                        dayschedule.Confirmed = false;
                        dayschedule.ConfirmedBy = null;
                        dayschedule.ConfirmedByName = null;
                    }

                    simpleschedule.Add(dayschedule);
                }
            }


            return simpleschedule;
        }


        public bool DayAttendancBlockLimit(int count, DateTime confirm_date, Employee employee)
        {

            int day_back = -1;
            var date = DateTime.Now;
            var limit = 0;
            while (true)
            {
                if (limit == count) break;

                var schedule = SimpleScheduleWithOverTimes(employee, new List<DateTime>() { date.AddDays(day_back) });
                if (schedule.Count()!=0)
                {
                    limit++;
                }
                day_back--;
            }
            if (DateTime.Now.AddDays(day_back).Date < confirm_date.Date)
            {
                return true;
            }
            else
                return false;
        }

    }


    public class SimpleScheduleModel
    {
        public DateTime Date { get; set; }
        public string DateFormated { get; set; }
        public string ShiftName { get; set; }
        public string FromFormated { get; set; }
        public string ToFormated { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }

        public bool? Confirmed { get; set; }
        public int? ConfirmedBy { get; set; }
        public string ConfirmedByName { get; set; }
        public string ScheduleColor { get; set; }
    }

    public class FromTo
    {
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
    }
}
