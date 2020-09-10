using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Data.Models;

namespace HUDEwiBlazor.Interfaces
{
    public interface IWorkCardService
    {
        bool? CheckIfMonthClosed(Employee emp, int Month, int Year);
    }
}
