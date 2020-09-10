using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HUDEwiBlazor.Data.Models;
using HUDEwiBlazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.ProtectedBrowserStorage;
using HUDEwiBlazor.Classes;
using HUDEwiBlazor.Data;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor.Calendars;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using Syncfusion.Blazor.Schedule;
using Microsoft.JSInterop;
using Syncfusion.Blazor;
using System.Globalization;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Notifications;

namespace HUDEwiBlazor.Components
{
    public class MainCallendarBase : ComponentBase
    {


        [Inject]
        protected ApplicationDBContext _context { get; set; }

        [Inject]
        protected ISecurity _security { get; set; }
        [Inject]
        protected IScheduleService _scheduleService { get; set; }
        [Inject]
        protected IEmailService _emailService { get; set; }
        [Inject]
        protected ISyncfusionStringLocalizer Localizer { get; set; }
        [Inject]
        protected NavigationManager navigationManager { get; set; }
        [Inject]
        protected ProtectedSessionStorage ProtectedSessionStore { get; set; }
        [Inject]
        protected ProtectedLocalStorage ProtectedLocalStorage { get; set; }
        [Inject]
        protected IHolidayApiService _holidayApiService { get; set; }
        [Inject]
        protected IDayActionsService _dayActionsService { get; set; }
        [Inject]
        protected IWorkCardService _workCardService { get; set; }
        [Parameter]
        public DateTime StartDate { get; set; } = DateTime.Now;
        [Parameter]
        public DayOfWeek StartFromDay { get; set; } = DayOfWeek.Monday;


        [Parameter]
        public SfToast BindingToast
        {
            get => ToastObj;
            set
            {
                if (ToastObj == value) return;
                ToastObj = value;
                BindingToastChanged.InvokeAsync(value);
            }
        }
        [Parameter]
        public EventCallback<SfToast> BindingToastChanged { get; set; }
        private SfToast ToastObj { get; set; }


        protected DateTime ActualDate { get; set; }
        protected List<DayModel> Days { get; set; } = new List<DayModel>();
        protected List<int> DaysHeader { get; set; } = new List<int>();
        protected Employee employee { get; set; }
        protected List<SimpleScheduleModel> simpleScheduleModel { get; set; } = new List<SimpleScheduleModel>();
        protected override async Task OnInitializedAsync()
        {
            string guid = await ProtectedSessionStore.GetAsync<string>("GUID");
            employee = _context.Employees.Where(x => x.GUID == guid).FirstOrDefault();
            if (employee == null)
            {
                navigationManager.NavigateTo("/",forceLoad:true);
            }
            ActualDate = StartDate;
            FillDayHeader();
            RenderCells();
            RenderGrid();
        }
        public override async Task SetParametersAsync(ParameterView parameters)
        {
           

            await base.SetParametersAsync(parameters);
        }
        private void FillDayHeader()
        {
            var start_int = (int)StartFromDay; 
            for (int i = 0; i < 7; i++)
            {
                DaysHeader.Add(start_int);
                if (start_int < 6)
                {
                    start_int = start_int + 1;
                }else
                {
                    start_int = 0;
                }
            }
        }
        protected void RenderToToday()
        {
            ActualDate = DateTime.Today;
            Days.Clear();
            RenderCells();
            RenderGrid(); 
        }
        private void RenderCells()
        {
            var firstDayOfMonth = new DateTime(ActualDate.Year, ActualDate.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            while ((int)firstDayOfMonth.DayOfWeek != DaysHeader.First())
            {
                firstDayOfMonth = firstDayOfMonth.AddDays(-1);
            }

            while ((int)lastDayOfMonth.DayOfWeek != DaysHeader.Last())
            {
                lastDayOfMonth = lastDayOfMonth.AddDays(1);
            }

            int id = 1;
            var code_list = new List<int?>();
            while(firstDayOfMonth <= lastDayOfMonth) //Cells Rendering
            {
                var day = new DayModel();
                day.SpanTitle = firstDayOfMonth.ToString("dddd, MMMM, yyyy");
                var daterange = new List<DateTime>();
                daterange.Add(firstDayOfMonth);
                var grid_day = _dayActionsService.GetDayActionsRangeForEmployeeWithCodes(employee, code_list, daterange, "dd-MM-yyyy");

                foreach (var da in grid_day)
                {
                    if (da.CodeName != "PRA" && da.CodeName != "PRAT" && da.CodeName != "PRAN" && !da.isHoliday && !da.isSaturday && !da.isSunday)
                    {
                        if (da.Confirmed == true)
                        {
                            day.DescTitle = da.CodeName;
                            day.SpanTitle = firstDayOfMonth.ToString("dddd, MMMM, yyyy")+"-"+ da.CodeName + "-" + da.CodeDesc;
                            if (da.CodeName != "DEL" && da.CodeName != "SZK")
                            {
                                day.DayClasses = day.DayClasses + " abs_free";
                            }
                        }
                    }else
                    {
                        var day_schedule = _scheduleService.SimpleScheduleWithOverTimes(employee, new List<DateTime>() { firstDayOfMonth }).FirstOrDefault();
                        if (day_schedule != null)
                        {
                            if (day_schedule.Confirmed == true)
                            {
                                day.DayClasses = day.DayClasses + " e-cell-confirmed";
                                day.confirmed = true;
                            }
                        }
                    }
                }
                if (firstDayOfMonth.DayOfWeek == DayOfWeek.Sunday)
                {
                    day.CellClasses = day.CellClasses + " e-weekend";
                    day.CellClasses = day.CellClasses + " e-highlightsunday";
                }
                if (firstDayOfMonth.DayOfWeek == DayOfWeek.Saturday)
                {
                    day.CellClasses = day.CellClasses + " e-weekend";
                    day.CellClasses = day.CellClasses + " e-highlightsaturday";
                }
               
                var holiday_api = _holidayApiService.GetHolidaysObjects(firstDayOfMonth, employee.HolidayCountry, employee.HolidayCountryState)
                    .Where(x => x.type == "National holiday" || x.type == "Common local holiday")
                    .FirstOrDefault();
                if (holiday_api != null)
                {
                    day.CellClasses = day.CellClasses + " free public";
                    day.SpanTitle = firstDayOfMonth.ToString("dddd, MMMM, yyyy") +"-"+holiday_api.name;
                }
                

               
                day.cell_id = "c_" + id.ToString();
                day.Day = firstDayOfMonth;
                Days.Add(day);
                id++;
                firstDayOfMonth = firstDayOfMonth.AddDays(1);
            }
        }

        private void RenderGrid()
        {
            simpleScheduleModel.Clear();
             var selected = Days.Where(x => x.Day.Date == DateTime.Today.Date).FirstOrDefault();
            selected.CellClasses = selected.CellClasses + " e-selected";
            selected.CellClasses = selected.CellClasses + " e-today";
            selected.selected = true;

            var grid_day = _dayActionsService.GetDayActionsRangeForEmployeeWithCodes(employee, null, new List<DateTime>() { selected.Day}, "dd-MM-yyyy");

            var gg_day = grid_day.Where(x => x.Date == selected.Day.Date && x.CodeName != "PRA" && x.CodeName != "PRAT" && x.CodeName != "PRAN");
            
            if (gg_day.Count() == 0)
                {
                    var day_schedule = _scheduleService.SimpleScheduleWithOverTimes(employee, new List<DateTime>() { selected.Day }).FirstOrDefault();
                    if (day_schedule != null)
                    {
                        if (day_schedule.Confirmed == true)
                        {
                            //selected.DayClasses = selected.DayClasses + " e-cell-confirmed";
                            //selected.confirmed = true;
                        }
                    }
                    simpleScheduleModel.Add(day_schedule);
                }
            StateHasChanged();
        }
        protected void OnNextMonth()
        {
            ActualDate = ActualDate.AddMonths(1);
            Days.Clear();
            RenderCells();
        }
        protected void OnLastMonth()
        {
            ActualDate = ActualDate.AddMonths(-1);
            Days.Clear();
            RenderCells();
        }
        protected void OnSelected(MouseEventArgs e, string cell_id)
        {
            simpleScheduleModel.Clear();
            if (e.CtrlKey == false)
            {
                var all_selected = Days.Where(x => x.selected == true);
                foreach (var s in all_selected)
                {
                    s.CellClasses = RemoveStringFromString(s.CellClasses, " e-selected");
                    s.selected = false;
                }
            }
            
            var selected = Days.Where(x => x.cell_id == cell_id).FirstOrDefault();
            selected.CellClasses = selected.CellClasses + " e-selected";
            selected.selected = true;



            var selected_for_grid = Days.Where(x => x.selected == true).Select(x => x.Day).ToList();

            var grid_day = _dayActionsService.GetDayActionsRangeForEmployeeWithCodes(employee, null, selected_for_grid, "dd-MM-yyyy");

            foreach (var dday in selected_for_grid)
            {
                var gg_day = grid_day.Where(x => x.Date == dday.Date && x.CodeName != "PRA" && x.CodeName!="PRAT" && x.CodeName != "PRAN");
                if (gg_day.Count() == 0)
                {
                    var day_schedule = _scheduleService.SimpleScheduleWithOverTimes(employee, new List<DateTime>() {dday }).FirstOrDefault();
                    if (day_schedule != null)
                    {
                        if (day_schedule.Confirmed == true)
                        {
                            selected.DayClasses = selected.DayClasses + " e-cell-confirmed";
                        }
                        simpleScheduleModel.Add(day_schedule);
                    }
                }
            }

            

            StateHasChanged();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "BL0005:Component parameter should not be set outside of its component.", Justification = "<Oczekujące>")]
        public async Task OnConfirm(MouseEventArgs e, string button_id)
        {
            var day_to_confirm = new DateTime();
            if (button_id == "Today")
            {
                day_to_confirm = DateTime.Today;
            }else
            {
                day_to_confirm = Days.Where(x => x.Day.ToString("d_M_yyyy") == button_id).Select(x => x.Day).FirstOrDefault();
            }
            var check_confirmed = Days.Where(x => x.Day.Date == day_to_confirm.Date).FirstOrDefault();
            if (check_confirmed != null)
            {
                if (check_confirmed.confirmed==true)
                {
                    BindingToast.Title = Localizer.GetText("AlreadyConfirmed");
                    BindingToast.Show();
                    return;
                }
            }
           
            var month_closed = _workCardService.CheckIfMonthClosed(employee, day_to_confirm.Month, day_to_confirm.Year);
            if (month_closed == null)
            {
                BindingToast.Title =  Localizer.GetText("NotExistWorkCard");
                BindingToast.Show();
                return;
            }
            else if (month_closed == true)
            {
                BindingToast.Title = Localizer.GetText("MonthClosed");
                BindingToast.Show();
                return;
            }
            if(day_to_confirm.Date > DateTime.Today.Date)
            {
                BindingToast.Title = Localizer.GetText("FutureConfirm");
                BindingToast.Show();
                return;
            }
            var back_limit = _context.SystemSettings.Select(x => x.AttendanceReminderLimit).First();
            var check_limit = _scheduleService.DayAttendancBlockLimit(back_limit, day_to_confirm, employee);
            if (check_limit == false)
            {
                BindingToast.Title = Localizer.GetText("DayLimit")+back_limit.ToString();
                BindingToast.Show();
                return;
            }

            var is_confirmed = await _dayActionsService.ConfirmDayFromCallendar(day_to_confirm, employee);
            if (is_confirmed)
            {
                BindingToast.Title = Localizer.GetText("ConfirmDayOk");
                BindingToast.Show();
                simpleScheduleModel.Where(x => x.Date == day_to_confirm).First().Confirmed = true;
                Days.Where(x=>x.Day == day_to_confirm).First().DayClasses = Days.Where(x => x.Day == day_to_confirm).First().DayClasses + " e-cell-confirmed";
                StateHasChanged();
                return;
            }else
            {
                BindingToast.Title = Localizer.GetText("ConfirmDayNok");
                BindingToast.Show();
                return;
            }
        }
        private string RemoveStringFromString(string sourceString, string removeString)
        {
            int index = sourceString.IndexOf(removeString);
            string cleanPath = (index < 0)
                ? sourceString
                : sourceString.Remove(index, removeString.Length);
            return cleanPath;
        }
    }

    public class DayModel
    {
        public string cell_id;
        public DateTime Day { get; set; }
        public string CellClasses { get; set; } = "e-cell";
        public string DayClasses { get; set; } = "e-day";
        public string DescClasses{ get; set; } = "";
        public bool selected { get; set; } = false;
        public bool confirmed { get; set; } = false;
        public string SpanTitle { get; set; } = "";
        public string DescTitle { get; set; } = "";

    }
}
