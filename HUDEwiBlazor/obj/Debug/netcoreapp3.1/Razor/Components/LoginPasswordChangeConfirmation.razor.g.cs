#pragma checksum "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\LoginPasswordChangeConfirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9cfcc9c0e922de6268c5de3381d4d4253190cb6"
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
    public partial class LoginPasswordChangeConfirmation : HUDEwiBlazor.Components.AuthenticateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "login100-form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<HUDEwiBlazor.Components.LocalizatinSwitcher>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "span");
            __builder.AddAttribute(6, "class", "login100-form-title p-b-43");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddContent(8, 
#nullable restore
#line 8 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\LoginPasswordChangeConfirmation.razor"
         Localizer.GetText("CongratulationsChangePassword")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "container-login100-form-btn");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\LoginPasswordChangeConfirmation.razor"
                          GoToHomePage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "login100-form-btn");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.AddContent(18, 
#nullable restore
#line 13 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\LoginPasswordChangeConfirmation.razor"
             Localizer.GetText("BackToLogin")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenComponent<HUDEwiBlazor.Components.Document>(23);
            __builder.AddAttribute(24, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\BKC\source\repos\ewiblazorserver\HUDEwiBlazor\Components\LoginPasswordChangeConfirmation.razor"
                  Localizer.GetText("Confirm")

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
