#pragma checksum "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b82737e29a0e28e481161e12aaba01b07509ad85"
// <auto-generated/>
#pragma warning disable 1591
namespace HUDEwiBlazor.Pages
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/main")]
    public partial class Main : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "limiter");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Notifications.SfToast>(3);
            __builder.AddAttribute(4, "ID", "toast_default");
            __builder.AddAttribute(5, "TimeOut", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 35 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                         50000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Icon", "e-meeting");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Notifications.ToastPosition>(9);
                __builder2.AddAttribute(10, "X", "Center");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(12, (__value) => {
#nullable restore
#line 35 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                      ToastObj = (Syncfusion.Blazor.Notifications.SfToast)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "container-login100");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "wrap-login100");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "login100-form validate-form");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenComponent<HUDEwiBlazor.Components.LocalizatinSwitcher>(23);
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "class", "login100-form-title-small p-b-43");
            __builder.AddAttribute(27, "style", "padding-bottom:20px !important;");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.AddContent(29, 
#nullable restore
#line 43 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                     Localizer.GetText("LoggedAs")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " ");
            __builder.OpenElement(31, "b");
            __builder.AddContent(32, 
#nullable restore
#line 43 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                       Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "span");
            __builder.AddAttribute(36, "class", "login100-form-title p-b-43");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.AddContent(38, 
#nullable restore
#line 46 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                     Localizer.GetText("YourWorkSchedule")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "id", "calender-control");
            __builder.AddAttribute(43, "class", "multiselectWrapper");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainCallendar>(45);
            __builder.AddAttribute(46, "BindingToast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Notifications.SfToast>(
#nullable restore
#line 49 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                                        ToastObj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "BindingToastChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Notifications.SfToast>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Notifications.SfToast>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ToastObj = __value, ToastObj))));
            __builder.AddComponentReferenceCapture(48, (__value) => {
#nullable restore
#line 49 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                         callendar = (HUDEwiBlazor.Components.MainCallendar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.AddMarkupContent(51, "<div class=\"schedule-section\">\r\n\r\n\r\n                </div>\r\n\r\n                <br>\r\n                <br>\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "container d-md-none d-lg-none d-xl-none");
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                     e=>callendar.OnConfirm(e, "Today")

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton2>(57);
            __builder.AddAttribute(58, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                                                               Localizer.GetText("Acknowledge_presence")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "Url", "#");
            __builder.AddAttribute(60, "type", "attendance");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton2>(62);
            __builder.AddAttribute(63, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                         Localizer.GetText("Vacation_On_Request")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "Url", "#");
            __builder.AddAttribute(65, "type", "demand");
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton2>(67);
            __builder.AddAttribute(68, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                         Localizer.GetText("Vacation_Leave")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "Url", "#");
            __builder.AddAttribute(70, "type", "holidays");
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton2>(72);
            __builder.AddAttribute(73, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                         Localizer.GetText("Work_Schedule")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "Url", "#");
            __builder.AddAttribute(75, "type", "schedule");
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton2>(77);
            __builder.AddAttribute(78, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                         Localizer.GetText("Advanced")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "Url", "/profil");
            __builder.AddAttribute(80, "type", "advanced");
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                               LogOut

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton2>(85);
            __builder.AddAttribute(86, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                            Localizer.GetText("LogOutEwi")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "Url", "#");
            __builder.AddAttribute(88, "type", "logout");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "login100-more2");
            __builder.AddAttribute(93, "style", "background-repeat:no-repeat; background-image: url(\'../images/hud_slide.jpg\');");
            __builder.AddMarkupContent(94, "\r\n\r\n\r\n                ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "container-fluid");
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "row");
            __builder.AddMarkupContent(100, "\r\n                        ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "col-sm-4");
            __builder.AddMarkupContent(103, "\r\n                            ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "thumbnail_container");
            __builder.AddMarkupContent(106, "\r\n                                ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "thumbnail");
            __builder.AddMarkupContent(109, "\r\n                                    ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                     e=>callendar.OnConfirm(e, "Today")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(112, "\r\n                                        ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton>(113);
            __builder.AddAttribute(114, "Url", "#");
            __builder.AddAttribute(115, "type", "attendance");
            __builder.AddAttribute(116, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                                                      Localizer.GetText("Acknowledge_presence")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "src", "../images/attendance.jpg");
            __builder.AddAttribute(118, "hover_src", "../images/attendance-t.jpg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(119, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                        ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "id", "demand_dialog");
            __builder.AddAttribute(126, "class", "col-sm-4");
            __builder.AddMarkupContent(127, "\r\n                            ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "thumbnail_container");
            __builder.AddMarkupContent(130, "\r\n                                ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "thumbnail");
            __builder.AddMarkupContent(133, "\r\n                                    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton>(134);
            __builder.AddAttribute(135, "Url", "#");
            __builder.AddAttribute(136, "type", "demand");
            __builder.AddAttribute(137, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 86 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                                              Localizer.GetText("Vacation_On_Request")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "src", "../images/demand.jpg");
            __builder.AddAttribute(139, "hover_src", "../images/demand-t.jpg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(140, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                        ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "col-sm-4");
            __builder.AddMarkupContent(146, "\r\n                            ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "thumbnail_container");
            __builder.AddMarkupContent(149, "\r\n                                ");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "thumbnail");
            __builder.AddMarkupContent(152, "\r\n                                    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton>(153);
            __builder.AddAttribute(154, "Url", "#");
            __builder.AddAttribute(155, "type", "holidays");
            __builder.AddAttribute(156, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 93 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                                                Localizer.GetText("Vacation_Leave")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(157, "src", "../images/holidays.jpg");
            __builder.AddAttribute(158, "hover_src", "../images/holidays-t.jpg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(159, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                    ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "row");
            __builder.AddMarkupContent(166, "\r\n                        ");
            __builder.OpenElement(167, "div");
            __builder.AddAttribute(168, "class", "offset-2 col-sm-4");
            __builder.AddMarkupContent(169, "\r\n                            ");
            __builder.OpenElement(170, "div");
            __builder.AddAttribute(171, "class", "thumbnail_container");
            __builder.AddMarkupContent(172, "\r\n                                ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "thumbnail");
            __builder.AddMarkupContent(175, "\r\n                                    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton>(176);
            __builder.AddAttribute(177, "Url", "#");
            __builder.AddAttribute(178, "type", "schedule");
            __builder.AddAttribute(179, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 102 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                                                Localizer.GetText("Work_Schedule")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(180, "src", "../images/schedule.jpg");
            __builder.AddAttribute(181, "hover_src", "../images/schedule-t.jpg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(182, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n                        ");
            __builder.OpenElement(186, "div");
            __builder.AddAttribute(187, "class", "offset-0 col-sm-4");
            __builder.AddMarkupContent(188, "\r\n                            ");
            __builder.OpenElement(189, "div");
            __builder.AddAttribute(190, "class", "thumbnail_container");
            __builder.AddMarkupContent(191, "\r\n                                ");
            __builder.OpenElement(192, "div");
            __builder.AddAttribute(193, "class", "thumbnail");
            __builder.AddMarkupContent(194, "\r\n                                    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.MainButton>(195);
            __builder.AddAttribute(196, "Url", "/profil");
            __builder.AddAttribute(197, "type", "advanced");
            __builder.AddAttribute(198, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 109 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
                                                                                      Localizer.GetText("Advanced")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(199, "src", "../images/advanced.jpg");
            __builder.AddAttribute(200, "hover_src", "../images/advanced-t.jpg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(201, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(207, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Main.razor"
 
    protected SfToast ToastObj;
    protected MainCallendar callendar;
    private string Name { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var guid = await SessionStorage.GetAsync<string>("GUID");
        if (guid != null)
        {
            var emp = _context.Employees.Where(x => x.GUID == guid).Select(x => new { x.Name, x.Surname }).FirstOrDefault();
            if (emp!=null)
            {
                Name = string.Join(" ", emp.Name, emp.Surname);
            }
        }
    }

    protected async Task LogOut()
    {
        await SessionStorage.DeleteAsync("GUID");
        NavigationManager.NavigateTo("/",forceLoad:true);
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage SessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDBContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncfusionStringLocalizer Localizer { get; set; }
    }
}
#pragma warning restore 1591
