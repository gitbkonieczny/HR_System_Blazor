#pragma checksum "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Profil.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc3ca8e5ad94e0bb7e0cb5a64183d750b7f2d455"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(SiteLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/profil")]
    public partial class Profil : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "Title");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Profil.razor"
     Localizer.GetText("Profil")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<HUDEwiBlazor.Components.UserProfile>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<HUDEwiBlazor.Components.Document>(8);
            __builder.AddAttribute(9, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Profil.razor"
                  Localizer.GetText("Profil")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncfusionStringLocalizer Localizer { get; set; }
    }
}
#pragma warning restore 1591
