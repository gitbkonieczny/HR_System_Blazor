#pragma checksum "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Shared\SiteLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90f5c726ee463f92e5a9b5a33ea635c45851f6ce"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HUDEwiBlazor.Shared
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
#line 13 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\_Imports.razor"
using HUDEwiBlazor.Classes;

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
#line 9 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Shared\SiteLayout.razor"
using HUDEwiBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Shared\SiteLayout.razor"
using HUDEwiBlazor.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Shared\SiteLayout.razor"
using HUDEwiBlazor.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Shared\SiteLayout.razor"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Shared\SiteLayout.razor"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Shared\SiteLayout.razor"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Shared\SiteLayout.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class SiteLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Shared\SiteLayout.razor"
      
    private bool isConnected = false;
    public string guid { get; set; }
    SfSidebar Sidebar;
    public Orientation Orientation = Orientation.Horizontal;
    public Orientation VerOrientation = Orientation.Vertical;
    Dictionary<string, object> HtmlAttribute = new Dictionary<string, object>()
{
        {"class", "sidebar-menu" }
    };
    public List<Syncfusion.Blazor.Navigations.MenuItem> AccountMenuItems = new List<Syncfusion.Blazor.Navigations.MenuItem>();
    public List<Syncfusion.Blazor.Navigations.MenuItem> MainMenuItems = new List<Syncfusion.Blazor.Navigations.MenuItem>();

    public string mode = "Dark Mode";
    public SfMenu SfMenu;


    protected override async Task OnInitializedAsync()
    {
        await LoadMenu();

    }

    public async Task Created()
    {
    }
    public async Task LoadMenu()
    {
        AccountMenuItems.Add(
        new Syncfusion.Blazor.Navigations.MenuItem()
        {
            Text = Localizer.GetText("Account"),
            Items = new List<Syncfusion.Blazor.Navigations.MenuItem>() {
                            new Syncfusion.Blazor.Navigations.MenuItem { Text = Localizer.GetText("Profil") , Url = "/profil" },
                            new Syncfusion.Blazor.Navigations.MenuItem { Text = Localizer.GetText("Home"), Url="/main" },
                            new Syncfusion.Blazor.Navigations.MenuItem { Text = Localizer.GetText("InfoBoard"), Url="/info" },
                            new Syncfusion.Blazor.Navigations.MenuItem { Text = Localizer.GetText("LogOutEwi"), Url="/logout" }
                               }
        }
       );
        guid = await ProtectedSessionStorage.GetAsync<string>("GUID");
        var employee = await iSecurity.GetEmployee(guid);
        var roles = await iSecurity.GetRolesForEmployee(employee);
        var menu_ids = new List<int?>();
        foreach (var role in roles)
        {
            var ids = role.LinkRolesMenuItem.Select(x => x.MenuItemID);
            menu_ids.AddRange(ids);
        }
        menu_ids = menu_ids.Distinct().ToList();
        var MenuFromDB = new List<Data.Models.MenuItem>();
        foreach (var menu in menu_ids)
        {
            var menu_record =  _context.MenuItem.Include(x => x.Items).Where(x => x.MenuItemId == menu && x.ParentID == null && x.Invisible == false).FirstOrDefault();
            if (menu_record != null)
            {
                var items = new List<Data.Models.MenuItem>();
                foreach (var item in menu_record.Items)
                {
                    if (menu_ids.Contains(item.MenuItemId))
                    {
                        items.Add(item);
                    }
                }
                menu_record.Items = items;
                MenuFromDB.Add(menu_record);
            }
        }
        //var MenuFromDB = _context.MenuItem.Include(x => x.Items).Where(x => x.ParentID == null).ToList();
        foreach (var menu in MenuFromDB)
        {
            var new_menu = new Syncfusion.Blazor.Navigations.MenuItem();
            //new_menu.ID = menu.MenuItemId.ToString();
            new_menu.IconCss = menu.IconCss + " icon";
            new_menu.Text = Localizer.GetText(menu.Text);
            new_menu.Url = menu.Url;
            if (menu.Items.Count == 0)
            {
                menu.Items = null;
            }
            if (menu.Items != null)
            {
                new_menu.Items = new List<Syncfusion.Blazor.Navigations.MenuItem>();

                foreach (var child in menu.Items)
                {
                    var child_item = new Syncfusion.Blazor.Navigations.MenuItem();
                    child_item.ID = child.MenuItemId.ToString();
                    child_item.IconCss = child.IconCss + " icon";
                    child_item.Text = Localizer.GetText(child.Text);
                    child_item.Url = child.Url;
                    new_menu.Items.Add(child_item);
                }
            }
            MainMenuItems.Add(new_menu);
        }
        StateHasChanged();
        
    }

    public void Toggle()
    {
        this.Sidebar.Toggle();
    }
    public void ToggleDarkMode()
    {
        if (mode == "Night Mode")
        {
            mode = "Day Mode";
        }else
        {
            mode = "Night Mode";
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            isConnected = true;
            await LoadStateAsync();
            StateHasChanged();
        }
    }

    private async Task LoadStateAsync()
    {
        guid = await ProtectedSessionStorage.GetAsync<string>
            ("GUID");
        if (guid == null)
        {
            NavigationManager.NavigateTo("/", forceLoad: true);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDBContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISecurity iSecurity { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage SessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncfusionStringLocalizer Localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOptions<RequestLocalizationOptions> LocOptions { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage ProtectedLocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStorage { get; set; }
    }
}
#pragma warning restore 1591
