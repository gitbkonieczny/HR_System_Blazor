#pragma checksum "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "706431e1afc22b279fb3096eca3a1d0f62f38c0c"
// <auto-generated/>
#pragma warning disable 1591
namespace HUDEwiBlazor.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using HUDEwiBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using HUDEwiBlazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using HUDEwiBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using HUDEwiBlazor.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using HUDEwiBlazor.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using HUDEwiBlazor.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using HUDEwiBlazor.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.QueryBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Classes.Mapped;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using HUDEwiBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class MainCallendar : HUDEwiBlazor.Components.MainCallendarBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "calender-control");
            __builder.AddAttribute(2, "class", "multiselectWrapper");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "calendar");
            __builder.AddAttribute(6, "class", "e-control e-calendar e-lib e-keyboard");
            __builder.AddAttribute(7, "tabindex", "0");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "e-header e-month");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "e-day e-title");
            __builder.AddAttribute(14, "aria-atomic", "true");
            __builder.AddAttribute(15, "aria-live", "assertive");
            __builder.AddAttribute(16, "aria-label", "title");
            __builder.AddContent(17, 
#nullable restore
#line 7 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                                                    ActualDate.ToString("MMMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "e-icon-container");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "e-prev");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "aria-disabled", "false");
            __builder.AddAttribute(26, "aria-label", "previous month");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                                                                 OnLastMonth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                    <span class=\"e-date-icon-prev e-icons\"></span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "e-next");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "aria-disabled", "false");
            __builder.AddAttribute(34, "aria-label", "next month");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                                                             OnNextMonth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                    <span class=\"e-date-icon-next  e-icons\"></span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "e-content e-month");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "tabindex", "0");
            __builder.AddAttribute(45, "role", "grid");
            __builder.AddAttribute(46, "aria-activedescendant", true);
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "thead");
            __builder.AddAttribute(49, "class", "e-week-header");
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 21 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                         foreach (var day in DaysHeader)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                            ");
            __builder.OpenElement(54, "th");
            __builder.AddContent(55, 
#nullable restore
#line 23 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                 DateTimeFormatInfo.CurrentInfo.GetShortestDayName((DayOfWeek)day)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 24 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "tbody");
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 28 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                      
                        for (int i = 0; i < Days.Count; i = i + 7)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                            ");
            __builder.OpenElement(63, "tr");
            __builder.AddAttribute(64, "class", true);
            __builder.AddAttribute(65, "role", "row");
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 32 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                 for (int day = i; day < i + 7; day++)
                                {
                                    string cell_id = Days[day].cell_id;

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                                    ");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "class", 
#nullable restore
#line 35 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                Days[day].CellClasses

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(70, "id", 
#nullable restore
#line 35 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                            cell_id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(71, "aria-selected", "false");
            __builder.AddAttribute(72, "role", "gridcell");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                                                                                       e=>OnSelected(e, cell_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(74, "\r\n                                        ");
            __builder.OpenElement(75, "span");
            __builder.AddAttribute(76, "title", 
#nullable restore
#line 36 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                      Days[day].SpanTitle

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(77, "class", 
#nullable restore
#line 36 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                                   Days[day].DayClasses

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, 
#nullable restore
#line 36 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                                                          Days[day].Day.Day

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                        ");
            __builder.OpenElement(80, "span");
            __builder.AddAttribute(81, "class", "desc");
            __builder.AddContent(82, 
#nullable restore
#line 37 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                            Days[day].DescTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 39 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 42 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                        }
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "e-footer-container");
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(94);
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                RenderToToday

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(97, 
#nullable restore
#line 48 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                Localizer.GetText("Calendar_Today")

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "e-grid");
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.OpenElement(105, "table");
            __builder.AddAttribute(106, "tabindex", "1");
            __builder.AddAttribute(107, "role", "grid");
            __builder.AddAttribute(108, "aria-activedescendant", true);
            __builder.AddAttribute(109, "width", "100%");
            __builder.AddMarkupContent(110, "\r\n        ");
            __builder.OpenElement(111, "tbody");
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 57 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
             foreach (var day in simpleScheduleModel)
            {
                string id = day.Date.ToString("d_M_yyyy");

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "                ");
            __builder.OpenElement(114, "tr");
            __builder.AddAttribute(115, "class", true);
            __builder.AddAttribute(116, "role", "row");
            __builder.AddMarkupContent(117, "\r\n                    ");
            __builder.OpenElement(118, "td");
            __builder.AddAttribute(119, "class", "e-rowcell");
            __builder.AddAttribute(120, "id", "Date_" + (
#nullable restore
#line 61 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                    id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(121, 
#nullable restore
#line 61 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                         day.DateFormated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.OpenElement(123, "td");
            __builder.AddAttribute(124, "class", "e-rowcell");
            __builder.AddAttribute(125, "id", "FromFormated_" + (
#nullable restore
#line 62 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                            id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(126, 
#nullable restore
#line 62 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                 day.FromFormated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                    ");
            __builder.OpenElement(128, "td");
            __builder.AddAttribute(129, "class", "e-rowcell");
            __builder.AddAttribute(130, "id", "ToFormated_" + (
#nullable restore
#line 63 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                          id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(131, 
#nullable restore
#line 63 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                               day.ToFormated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.OpenElement(133, "td");
            __builder.AddAttribute(134, "class", "e-rowcell");
            __builder.AddAttribute(135, "id", "Confirmed_" + (
#nullable restore
#line 64 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                         id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(136, "\r\n");
#nullable restore
#line 65 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                         if (day.Confirmed == true)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(137, "                            ");
            __builder.AddMarkupContent(138, "<div class=\"e-checkbox-wrapper e-css e-checkbox-disabled\"><span class=\"e-frame e-icons e-check\"></span><span class=\"e-label\"> </span></div>\r\n");
#nullable restore
#line 68 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(139, "                            ");
            __builder.AddMarkupContent(140, "<div class=\"e-checkbox-wrapper e-css e-checkbox-disabled\"><span class=\"e-frame e-icons\"></span><span class=\"e-label\"> </span></div>\r\n");
#nullable restore
#line 72 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(141, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                    ");
            __builder.OpenElement(143, "td");
            __builder.AddAttribute(144, "class", "e-rowcell");
            __builder.AddAttribute(145, "id", "Td_button_" + (
#nullable restore
#line 74 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                         id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 75 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                         if (day.Confirmed == false)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(147, "                            ");
            __builder.OpenElement(148, "div");
            __builder.AddAttribute(149, "class", "e-unboundcelldiv");
            __builder.AddAttribute(150, "style", "display: inline-block");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(151);
            __builder.AddAttribute(152, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                                                              e=>OnConfirm(e, id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(153, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(154, 
#nullable restore
#line 77 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
                                                                                                                                     Localizer.GetText("Confirm")

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n");
#nullable restore
#line 78 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"

                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(156, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n");
#nullable restore
#line 82 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\MainCallendar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(159, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n");
            __builder.AddMarkupContent(163, "<style>\r\n\r\n    .abs_free {\r\n        color:darkgrey !important; \r\n        font-weight:1000 !important;\r\n    }\r\n    .e-cell-confirmed {\r\n        color: lightgreen !important;\r\n        font-weight: 1000 !important;\r\n    }\r\n    .e-checkbox-wrapper.e-checkbox-disabled .e-frame.e-check, .e-css.e-checkbox-wrapper.e-checkbox-disabled .e-frame.e-check {\r\n        background-color: lightgreen;\r\n        border-color: lightgreen;\r\n        color: #fff;\r\n    }\r\n    .e-btn {\r\n        background-color: #6675df !important;\r\n    }\r\n    .e-grid .e-rowcell {\r\n        height:50px !important;\r\n    }\r\n    .e-grid {\r\n        background-color: #fff !important;\r\n    }\r\n    .control-section {\r\n        height: 100%;\r\n    }\r\n\r\n    .e-calendar {\r\n        max-width: none !important;\r\n    }\r\n\r\n    span.highlight {\r\n        font-family: Poppins-Regular, sans-serif;\r\n        font-size: 10px;\r\n        display: block;\r\n        margin-left: -5px;\r\n        width: auto;\r\n        height: 20px;\r\n    }\r\n\r\n    span.desc,\r\n    span.desc:before {\r\n        color: rgb(0, 0, 255) !important;\r\n    }\r\n\r\n    .e-other-month span.desc:before {\r\n        content: \"\";\r\n    }\r\n\r\n    span.desc:before {\r\n        content: \"\";\r\n        vertical-align: middle;\r\n        margin-right: 3px;\r\n        font-size: 4px;\r\n        position: relative;\r\n        top: 0px;\r\n        font-weight: normal;\r\n        display: block;\r\n    }\r\n\r\n    .e-bigger.e-calendar span.desc:before,\r\n    .e-bigger .e-calendar span.desc:before {\r\n    }\r\n\r\n    .e-calendar .e-content td.public span.e-day, .e-calendar .e-content td.public:hover span.e-day, .e-calendar .e-content td.public:focus span.e-day, .e-bigger.e-small .e-calendar .e-content td.public span.e-day, .e-bigger.e-small .e-calendar .e-content td.public:hover span.e-day, .e-bigger.e-small .e-calendar .e-content td.public:focus span.e-day {\r\n        color: red !important;\r\n        font-weight: 1000;\r\n    }\r\n\r\n\r\n    .e-calendar .e-content td.nopublic span.e-day, .e-calendar .e-content td.nopublic:hover span.e-day, .e-calendar .e-content td.nopublic:focus span.e-day, .e-bigger.e-small .e-calendar .e-content td.nopublic span.e-day, .e-bigger.e-small .e-calendar .e-content td.nopublic:hover span.e-day, .e-bigger.e-small .e-calendar .e-content td.nopublic:focus span.e-day {\r\n        color: blue !important;\r\n    }\r\n\r\n\r\n    .e-calendar .e-content td.e-highlightsunday span.e-day, .e-calendar .e-content td.e-highlightsunday:hover span.e-day, .e-calendar .e-content td.e-highlightsunday:focus span.e-day, .e-bigger.e-small .e-calendar .e-content td.e-highlightsunday span.e-day, .e-bigger.e-small .e-calendar .e-content td.e-highlightsunday:hover span.e-day, .e-bigger.e-small .e-calendar .e-content td.e-highlightsunday:focus span.e-day {\r\n        color: red !important;\r\n        font-weight: 1000;\r\n    }\r\n\r\n    .e-calendar .e-content td.e-weekend:not(.e-other-month), .e-calendar .e-content td.e-weekend:hover:not(.e-other-month), .e-calendar .e-content td.e-weekend:focus:not(.e-other-month), .e-bigger.e-small .e-calendar .e-content td.e-weekend:not(.e-other-month), .e-bigger.e-small .e-calendar .e-content td.e-weekend:hover:not(.e-other-month), .e-bigger.e-small .e-calendar .e-content td.e-weekend:focus:not(.e-other-month) {\r\n        background-color: lightgrey;\r\n    }\r\n\r\n    .e-calendar .e-content td, .e-calendar .e-content td:hover, .e-calendar .e-content td:focus, .e-bigger.e-small .e-calendar .e-content td, .e-bigger.e-small .e-calendar .e-content td:hover, .e-bigger.e-small .e-calendar .e-content td:focus {\r\n        vertical-align: top;\r\n        height: 50px;\r\n    }\r\n\r\n   .e-calendar .e-content td.e-disabled, .e-bigger.e-small .e-calendar .e-content td.e-disabled {\r\n            opacity: 0.8 !important;\r\n        }\r\n\r\n   .e-calendar .e-content td.e-cell, .e-bigger.e-small .e-calendar .e-content td.e-cell {\r\n            height: 50px !important;\r\n        }\r\n</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncfusionStringLocalizer Localizer { get; set; }
    }
}
#pragma warning restore 1591
