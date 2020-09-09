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

namespace HUDEwiBlazor.Components
{
    public class MainCallendarBase : ComponentBase
    {


        [Inject]
        protected ApplicationDBContext _context { get; set; }

        [Inject]
        protected ISecurity _security { get; set; }

        [Inject]
        protected IEmailService _emailService { get; set; }

        [Inject]
        protected NavigationManager navigationManager { get; set; }
        [Inject]
        protected ProtectedSessionStorage ProtectedSessionStore { get; set; }
        [Inject]
        protected ProtectedLocalStorage ProtectedLocalStorage { get; set; }


       

    }

  
}
