using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Data.Models;

namespace HUDEwiBlazor.Interfaces
{
    public interface ISecurity
    {
        Task<(bool, string)> Authenticate(string email, string password);
        Task<bool> IsEmail(string email);
        Task<PasswordLink> GetResetLinkByEmail(string email);
        Task DeletePasswordLink(string link);
        Task<PasswordLink> SaveLink(string email);
        Task<bool> CheckLinkExist(string link);
        Task<bool> ChangePassword(string password, string link);
        Task<bool> ChangePasswordforGuid(string password, string guid);
        Task<List<Roles>> GetRolesForEmployee(Employee employee);
        Task<Employee> GetEmployee(string guid);
        Task<Employee> GetEmployee(int id);
        List<Employee> GetEmployees();
        Task<List<Employee>> GetEmployeesAsync();
        Task<List<Roles>> GetRolesAsync();
        List<Roles> GetRoles();
        Roles GetRole(int roleid);
        List<MenuItem> GetMenuItems();
        Task<List<MenuItem>> GetMenuItemsAsync();
        Task<(string, string, Roles)> AddRole(Roles role);
        Task<(string, string, Roles)> UpdateRole(Roles role);
        Task<(string, string)> DeleteRole(Roles role);
        Task<(string, string)> RemoveEmployeeFromRoles(int? RolesID, List<int> EmployeeList);
        Task<(string, string)> AddEmployeeToRoles(int? RolesID, List<int> EmployeeList);
        Task<(string, string)> RemoveMenuFromRoles(int? RolesID, List<int> MenuList);
        Task<(string, string)> AddMenuToRoles(int? RolesID, List<int> MenuList);
        List<Gender> GetAllGenders();
        Task<List<Employee>> GetAllUsers();

        Task<(string, string, Employee)> AddEmployee(Employee employee);
        Task<(string, string, Employee)> UpdateEmployee(Employee employee);
        Task<(string, string)> DeleteEmployee(Employee employee);
        Task<byte[]> SaveAvatar(int emp, byte[] file);
        Task<(string, string, Employee)> UpdateRolesForEmployee(int[] Roles, int employeeid);

    }
}
