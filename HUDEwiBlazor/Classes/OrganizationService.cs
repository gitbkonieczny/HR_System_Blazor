using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Data;
using HUDEwiBlazor.Data.Models;
using HUDEwiBlazor.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HUDEwiBlazor.Classes
{
    public class OrganizationService: IOrganizationService
    {
        private readonly ApplicationDBContext _context;

        public OrganizationService(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task <List<Projects>> GetProjectsForEmployee(Employee emp)
        {
            List<Projects> projects = new List<Projects>();
            try
            {
                var emp_teams = await _context.LinkTeamsEmployee.Where(x => x.EmployeeID == emp.EmployeeID).ToListAsync();
                if (emp_teams.Count() != 0)
                {
                    foreach (var item in emp_teams)
                    {
                        var project = await GetProjectsforTeamId(item.TeamId);
                        projects.Add(project);
                    }
                    return projects;
                }
                return projects;
            }
            catch
            {
                return projects;
            }
        }
        public async Task<Projects> GetProjectsforTeamId(int? team_id)
        {
            var team = _context.Teams.Where(x => x.TeamId == team_id).FirstOrDefault();
            if (team != null)
            {
                var join = await _context.Projects.Where(x => x.ProjectID == team.ProjectID).FirstOrDefaultAsync();
                if (join != null)
                {
                    return join;
                }
                else
                {
                    return null;
                }
            }
            else return null;

        }
    }
}
