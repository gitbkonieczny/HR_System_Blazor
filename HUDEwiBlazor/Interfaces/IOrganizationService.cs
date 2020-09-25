using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Data.Models;

namespace HUDEwiBlazor.Interfaces
{
    public interface IOrganizationService
    {
        Task<Projects> GetProjectsforTeamId(int? team_id);
        Task<List<Projects>> GetProjectsForEmployee(Employee emp);
    }
}
