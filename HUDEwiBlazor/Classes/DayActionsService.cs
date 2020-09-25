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
    public class DayActionsService: IDayActionsService
    {
        private readonly ApplicationDBContext _context;
        private IHolidayApiService _holidayApiService;
        private IScheduleService _scheduleService;
        public DayActionsService(ApplicationDBContext context, IHolidayApiService holidayApiService, IScheduleService scheduleService)
        {
            this._context = context;
            this._holidayApiService = holidayApiService;
            this._scheduleService = scheduleService;
        }

        public List<DayActionGridList> GetDayActionsRangeForEmployeeWithCodes(Employee emp, List<int?> CodeID, List<DateTime> daterange, string format)
        {
            var flist = new List<DayActionGridList>();
            try
            {
                if (CodeID != null && CodeID.Count() != 0)
                {

                    var code_abs = new List<DayActions>();
                    foreach (var code in CodeID)
                    {
                        code_abs.AddRange(_context.DayActions.Where(x => x.EmployeeID == emp.EmployeeID && x.CodeID == code.Value).ToList());
                    }

                    foreach (var item in daterange)
                    {
                        var abs_temp = code_abs.Where(x => x.FromDateID.Date <= item.Date && x.ToDateID.Date >= item.Date);
                        foreach (var abs in abs_temp)
                        {
                            if (abs != null)
                            {
                                var new_api_abs = new DayActionGridList();
                                new_api_abs.isHoliday = false;
                                new_api_abs.isSaturday = false;
                                new_api_abs.isSunday = false;

                                var holiday = _holidayApiService.GetHolidaysObjects(item, emp.HolidayCountry, emp.HolidayCountryState);
                                if (holiday.Count() != 0)
                                {
                                    foreach (var h in holiday)
                                    {
                                        if (h.type == "National holiday" || h.type == "Common local holiday")
                                        {
                                            new_api_abs.isHoliday = true;
                                        }
                                    }
                                }

                                if (item.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    new_api_abs.isSaturday = true;
                                }

                                if (item.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    new_api_abs.isSunday = true;
                                }
                                new_api_abs.DayActionsID = abs.DayActionsID;
                                new_api_abs.SubmissionDate = abs.SubmissionDate;
                                new_api_abs.ChildID = abs.ChildID;
                                new_api_abs.CodeID = abs.CodeID;
                                new_api_abs.EmployeeID = abs.EmployeeID;
                                new_api_abs.Description = abs.Description;
                                new_api_abs.Confirmed = abs.Confirmed;
                                new_api_abs.ConfirmedBy = abs.ConfirmedBy;
                                new_api_abs.EventID = abs.EventID;
                                new_api_abs.Latitude = abs.Latitude;
                                new_api_abs.Longitude = abs.Longitude;
                                new_api_abs.FromShift = abs.FromShift;
                                new_api_abs.ToShift = abs.ToShift;
                                new_api_abs.From = abs.From;
                                new_api_abs.To = abs.To;
                                new_api_abs.ShowOnCard = abs.ShowOnCard;
                                if (abs.CodeID != null)
                                {
                                    var code = _context.Codes.Where(x => x.CodeID == abs.CodeID).FirstOrDefault();
                                    if (code != null)
                                    {
                                        new_api_abs.CodeName = code.Code;
                                        new_api_abs.CodeDesc = code.Description;
                                    }
                                }
                                if (abs.ConfirmedBy != null) new_api_abs.ConfirmedByName = _context.Employees.Where(x => x.EmployeeID == abs.ConfirmedBy).FirstOrDefault().Name + " " + _context.Employees.Where(x => x.EmployeeID == abs.ConfirmedBy).FirstOrDefault().Surname;
                                if (abs.EmployeeID != null) new_api_abs.EmployeeName = _context.Employees.Where(x => x.EmployeeID == abs.EmployeeID).FirstOrDefault().Name + " " + _context.Employees.Where(x => x.EmployeeID == abs.EmployeeID).FirstOrDefault().Surname;
                                new_api_abs.Date = item;
                                if (new_api_abs.Date != null) new_api_abs.DateFormated = item.ToString(format);
                                if (new_api_abs.SubmissionDate != null) new_api_abs.SubmissionDateFormated = new_api_abs.SubmissionDate.ToString(format);

                                flist.Add(new_api_abs);
                            }
                        }


                    }
                }
                else
                {
                    var nocodeabs = _context.DayActions.Where(x => x.EmployeeID == emp.EmployeeID).ToList();


                    foreach (var item in daterange)
                    {
                        var abs_temp = nocodeabs.Where(x => x.FromDateID.Date <= item.Date && x.ToDateID.Date >= item.Date);
                        foreach (var abs in abs_temp)
                        {
                            if (abs_temp != null)
                            {
                                var new_api_abs = new DayActionGridList();

                                new_api_abs.isHoliday = false;
                                new_api_abs.isSaturday = false;
                                new_api_abs.isSunday = false;

                                var holiday = _holidayApiService.GetHolidaysObjects(item, emp.HolidayCountry, emp.HolidayCountryState);
                                if (holiday.Count() != 0)
                                {
                                    foreach (var h in holiday)
                                    {
                                        if (h.type == "National holiday" || h.type == "Common local holiday")
                                        {
                                            new_api_abs.isHoliday = true;
                                        }
                                    }
                                }

                                if (item.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    new_api_abs.isSaturday = true;
                                }

                                if (item.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    new_api_abs.isSunday = true;
                                }

                                new_api_abs.DayActionsID = abs.DayActionsID;
                                new_api_abs.SubmissionDate = abs.SubmissionDate;
                                new_api_abs.ChildID = abs.ChildID;
                                new_api_abs.CodeID = abs.CodeID;
                                new_api_abs.EmployeeID = abs.EmployeeID;
                                new_api_abs.Description = abs.Description;
                                new_api_abs.Confirmed = abs.Confirmed;
                                new_api_abs.ConfirmedBy = abs.ConfirmedBy;
                                new_api_abs.EventID = abs.EventID;
                                new_api_abs.Latitude = abs.Latitude;
                                new_api_abs.Longitude = abs.Longitude;
                                new_api_abs.FromShift = abs.FromShift;
                                new_api_abs.ToShift = abs.ToShift;
                                new_api_abs.From = abs.From;
                                new_api_abs.To = abs.To;
                                new_api_abs.ShowOnCard = abs.ShowOnCard;

                                if (abs.CodeID != null)
                                {
                                    var code = _context.Codes.Where(x => x.CodeID == abs.CodeID).FirstOrDefault();
                                    if (code != null)
                                    {
                                        new_api_abs.CodeName = code.Code;
                                        new_api_abs.CodeDesc = code.Description;
                                    }
                                }
                                if (abs.ConfirmedBy != null) new_api_abs.ConfirmedByName = _context.Employees.Where(x => x.EmployeeID == abs.ConfirmedBy).FirstOrDefault().Name + " " + _context.Employees.Where(x => x.EmployeeID == abs.ConfirmedBy).FirstOrDefault().Surname;
                                if (abs.EmployeeID != null) new_api_abs.EmployeeName = _context.Employees.Where(x => x.EmployeeID == abs.EmployeeID).FirstOrDefault().Name + " " + _context.Employees.Where(x => x.EmployeeID == abs.EmployeeID).FirstOrDefault().Surname;
                                new_api_abs.Date = item;
                                if (new_api_abs.Date != null) new_api_abs.DateFormated = item.ToString(format);
                                if (new_api_abs.SubmissionDate != null) new_api_abs.SubmissionDateFormated = new_api_abs.SubmissionDate.ToString(format);
                                flist.Add(new_api_abs);
                            }
                        }


                    }

                }


                return flist;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public async Task<bool> ConfirmDayFromCallendar(DateTime date, Employee employee)
        {
            try
            {
                var confirmed = new DayActions();
                var get_schedule = _scheduleService.SimpleScheduleWithOverTimes(employee, new List<DateTime>() { date }).FirstOrDefault();
                if (get_schedule != null)
                {
                    confirmed.EmployeeID = employee.EmployeeID;
                    confirmed.FromDateID = get_schedule.Date;
                    confirmed.ToDateID = get_schedule.Date;
                    confirmed.CodeID = _context.Codes.Where(x => x.Code == "PRA").Select(x => x.CodeID).FirstOrDefault();
                    confirmed.Confirmed = true;
                    confirmed.ConfirmedBy = employee.EmployeeID;
                    confirmed.SubmissionDate = DateTime.Now.ToLocalTime();
                    confirmed.From = get_schedule.From;
                    confirmed.To = get_schedule.To;
                    confirmed.FromShift = get_schedule.FromFormated;
                    confirmed.ToShift = get_schedule.ToFormated;
                    _context.DayActions.Add(confirmed);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;


        }

    }
    public class DayActionGridList
    {
        public int? DayActionsID { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string SubmissionDateFormated { get; set; }

        public int? EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public DateTime Date { get; set; }

        public string DateFormated { get; set; }
        public bool? Confirmed { get; set; } //null-to accept wait or reject, true-accepted, false - rejected
        public int? ConfirmedBy { get; set; }

        public string ConfirmedByName { get; set; }

        public int? CodeID { get; set; }
        public string CodeName { get; set; }
        public string CodeDesc { get; set; }
        public int? EventID { get; set; }
        public int? ChildID { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Description { get; set; }
        public string FromShift { get; set; }
        public string ToShift { get; set; }

        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }

        public bool isHoliday { get; set; }
        public bool isSaturday { get; set; }
        public bool isSunday { get; set; }
        public bool ShowOnCard { get; set; }

    }
}
