#pragma checksum "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d7b5ba33612d54a86ac75848cfdc2129a2af5c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/logout")]
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Logout.razor"
      
    protected override async Task OnInitializedAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Pages\Logout.razor"
        await SessionStorage.DeleteAsync("GUID");
        NavigationManager.NavigateTo("/", forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage SessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
