using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using HUDEwiBlazor.Interfaces;
using HUDEwiBlazor.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HUDEwiBlazor.Data.Models;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Immutable;
using shortid;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components;

namespace HUDEwiBlazor.Classes
{
    public class Security:ISecurity
    {
        private readonly ApplicationDBContext _context;
        private Syncfusion.Blazor.ISyncfusionStringLocalizer _localizer;
        private IOrganizationService _organizationService;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IEmailService _emailService;
        private NavigationManager _navigationManager;
        public Security(ApplicationDBContext context, NavigationManager navigationManager ,IEmailService emailService, Syncfusion.Blazor.ISyncfusionStringLocalizer localizer, IOrganizationService organizationService, IWebHostEnvironment hostingEnvironment)
        {
            _organizationService = organizationService;
            _navigationManager = navigationManager;
            _emailService = emailService;
            _localizer = localizer;
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }
        public async Task<(bool, string)> Authenticate (string email, string password)
        {
            var check_email = await _context.Employees.Where(x => x.Email == email.ToLower()).FirstOrDefaultAsync();
            if (check_email == null)
            {
                return (false, null);
            }

            byte[] Salt = await GetSalt(email);
            var hashed_password = PasswordHash(password, Salt);

            if (await IsAuthentic(email, hashed_password))
            {
                return (true, check_email.GUID);
            }
            return (false, null);
        }

        public async Task<bool> IsEmail(string email)
        {
            var check_email = await _context.Employees.Where(x => x.Email == email.ToLower()).FirstOrDefaultAsync();
            if (check_email == null)
            {
                return false;
            }else
            {
                return true;
            }
        }

        private async Task<bool> IsAuthentic(string Email, string Password)
        {
            var user = await _context.Employees.Where(x => x.Email == Email.ToLower()).FirstOrDefaultAsync();
            if (user != null)
            {
                if (user.Email.ToLower().Equals(Email.ToLower()) && user.Password.Equals(Password))
                {
                    return true;
                }
            }

            return false;
        }

        private async Task<byte[]> GetSalt(string Email)
        {
            var salt_Obj = await _context.Employees.Where(x => x.Email == Email.ToLower()).FirstOrDefaultAsync();
            if (salt_Obj != null) return salt_Obj.Salt;
            return null;
        }
        /// <summary>
        /// Generates a Random Password
        /// respecting the given strength requirements.
        /// </summary>
        /// <returns>A random password</returns>
        private string GenerateRandomPassword()
        {

            string[] randomChars = new[] {
                        "ABCDEFGHJKLMNOPQRSTUVWXYZ",    // uppercase 
                        "abcdefghijkmnopqrstuvwxyz",    // lowercase
                        "0123456789",                   // digits
                        "!@$?_-"                        // non-alphanumeric
                    };
            Random rand = new Random(Environment.TickCount);
            List<char> chars = new List<char>();

            var get_passwordOptions = _context.PasswordOptions.FirstOrDefault();

            if (get_passwordOptions.RequireUppercase)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[0][rand.Next(0, randomChars[0].Length)]);

            if (get_passwordOptions.RequireLowercase)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[1][rand.Next(0, randomChars[1].Length)]);

            if (get_passwordOptions.RequireDigit)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[2][rand.Next(0, randomChars[2].Length)]);

            if (get_passwordOptions.RequireNonAlphanumeric)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[3][rand.Next(0, randomChars[3].Length)]);

            for (int i = chars.Count; i < get_passwordOptions.RequiredLength
                || chars.Distinct().Count() < get_passwordOptions.RequiredUniqueChars; i++)
            {
                string rcs = randomChars[rand.Next(0, randomChars.Length)];
                chars.Insert(rand.Next(0, chars.Count),
                    rcs[rand.Next(0, rcs.Length)]);
            }

            return new string(chars.ToArray());
        }

        private byte[] SaltGenerate()
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
        private string PasswordHash(string password, byte[] Salt)
        {
           
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: Salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));

            return hashed;
        }

        public async Task<PasswordLink> GetResetLinkByEmail(string email)
        {
            return await _context.PasswordLink.Where(x => x.Email == email).FirstOrDefaultAsync();
        }
        public async Task DeletePasswordLink(string link)
        {
            
                var dellink = await _context.PasswordLink.Where(x => x.Link == link).FirstOrDefaultAsync();
                if (dellink != null)
                {
                    _context.PasswordLink.Remove(dellink);
                    await _context.SaveChangesAsync();
                }
            
            
        }
        public async Task<bool> ChangePassword(string password, string link)
        {
            try
            {
                var email = await _context.PasswordLink.Where(x => x.Link == link).FirstOrDefaultAsync();
                if (email == null)
                {
                    return false;
                }

                var employee = await _context.Employees.Where(x => x.Email.ToLower() == email.Email.ToLower()).FirstOrDefaultAsync();
                var salt = await GetSalt(email.Email);
                employee.Password = PasswordHash(password, salt);
                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();
                await DeletePasswordLink(link);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> ChangePasswordforGuid(string password, string guid)
        {
            try
            {
                var employee = await _context.Employees.Where(x => x.GUID == guid).FirstOrDefaultAsync();
                var salt = await GetSalt(employee.Email);
                employee.Password = PasswordHash(password, salt);
                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> CheckLinkExist(string link)
        {
            try
            {
                var flink = await _context.PasswordLink.Where(x => x.Link == link).FirstOrDefaultAsync();
                if (flink != null)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                int t=0;
                return false;
            }
            
        }
        private string GenerateRandomLink(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        public async Task<PasswordLink> SaveLink(string email)
        {
            var check_link = await GetResetLinkByEmail(email);
            if (check_link != null)
            {
                await DeletePasswordLink(check_link.Link);
            }
            var p_link = new PasswordLink();
            p_link.Email = email;
            p_link.Link = GenerateRandomLink(100,true);
            _context.PasswordLink.Add(p_link);
            await _context.SaveChangesAsync();
            return p_link;
        }

        public async Task<List<Roles>> GetRolesForEmployee(Employee employee)
        {
            var ids = new List<Roles>();
            var linkemploye = await _context.LinkEmployeRoles
                .Include(x => x.Roles)
                .ThenInclude(x=>x.LinkRolesMenuItem)
                .Where(x => x.EmployeeID == employee.EmployeeID).ToListAsync();

            foreach (var item in linkemploye)
            {
                ids.Add(item.Roles);
            }
            return ids;
        }

        public async Task<List<Roles>> GetRolesAsync()
        {
            var roles = await _context.Roles
                .Include(x => x.LinkEmployeRoles)
                    .ThenInclude(x => x.Employee)
                .Include(x => x.LinkRolesMenuItem)
                    .ThenInclude(x=>x.MenuItem)
                .ToListAsync();

            foreach (var role in roles)
            {
                if (role.LinkEmployeRoles.ToList().Count()!=0)
                {
                    role.Users = String.Join(", ", role.LinkEmployeRoles.ToList().Select(x => x.Employee.Name + " " + x.Employee.Surname));
                    role.UsersID = role.LinkEmployeRoles.Where(x=>x.EmployeeID != null).Select(x => (int)x.EmployeeID).ToArray();
                    role.MenusID = role.LinkRolesMenuItem.Where(x => x.MenuItemID != null).Select(x => (int)x.MenuItemID).ToArray();
                }
            }
            return roles;
        }

        public  List<Roles> GetRoles()
        {
            var roles =  _context.Roles
                .Include(x => x.LinkEmployeRoles)
                    .ThenInclude(x => x.Employee)
                .Include(x => x.LinkRolesMenuItem)
                    .ThenInclude(x => x.MenuItem)
                .ToList();

            foreach (var role in roles)
            {
                if (role.LinkEmployeRoles.ToList().Count() != 0)
                {
                    role.Users = String.Join(", ", role.LinkEmployeRoles.ToList().Select(x => x.Employee.Name + " " + x.Employee.Surname));
                    role.UsersID = role.LinkEmployeRoles.Where(x => x.EmployeeID != null).Select(x => (int)x.EmployeeID).ToArray();
                    role.MenusID = role.LinkRolesMenuItem.Where(x => x.MenuItemID != null).Select(x => (int)x.MenuItemID).ToArray();
                }
            }
            return roles;
        }
        public Roles GetRole(int roleid)
        {
            var role = _context.Roles
                .Include(x => x.LinkEmployeRoles)
                    .ThenInclude(x => x.Employee)
                .Include(x => x.LinkRolesMenuItem)
                    .ThenInclude(x => x.MenuItem).Where(x => x.RolesID == roleid).FirstOrDefault();


            if (role != null)
            {
                if (role.LinkEmployeRoles.ToList().Count() != 0)
                {
                    role.Users = String.Join(", ", role.LinkEmployeRoles.ToList().Select(x => x.Employee.Name + " " + x.Employee.Surname));
                    role.UsersID = role.LinkEmployeRoles.Where(x => x.EmployeeID != null).Select(x => (int)x.EmployeeID).ToArray();
                    role.MenusID = role.LinkRolesMenuItem.Where(x => x.MenuItemID != null).Select(x => (int)x.MenuItemID).ToArray();
                }
            }
            return role;
        }
        public List<Employee> GetEmployees()
        {
            var employee =  _context.Employees.ToList(); 
            return employee;
        }
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var employee = await _context.Employees.ToListAsync();
            return employee;
        }
        public List<MenuItem> GetMenuItems()
        {
            var menu = _context.MenuItem.ToList();
            return menu;
        }
        public async Task<List<MenuItem>> GetMenuItemsAsync()
        {
            var menu = await _context.MenuItem.ToListAsync();
            return menu;
        }
        public async Task<Employee> GetEmployee(string guid)
        {
            var employee = await _context.Employees.Include(x => x.LinkEmployeRoles).ThenInclude(x => x.Roles).Where(x => x.GUID == guid).FirstOrDefaultAsync();
            if (employee.Gender != null)
            {
                employee.GenderName = GetAllGenders().Where(x => x.Value == employee.Gender).FirstOrDefault().Name;
            }
            if (employee.LinkEmployeRoles != null)
            {
                var roles = await GetRolesForEmployee(employee);
                if (roles.Count() != 0)
                {
                    employee.Roles = String.Join(", ", roles.Select(x => x.Name));
                    employee.RolesID = roles.Select(x => (int)x.RolesID).ToArray();
                }
            }
            var user_projects = await _organizationService.GetProjectsForEmployee(employee);
            if (user_projects.Count() != 0)
            {
                employee.ProjectsNames = string.Join(Environment.NewLine, user_projects.Select(x => x.Name));
            }
            if (employee.BirthDate.HasValue)
            {
                employee.BirthDateFormated = employee.BirthDate.Value.ToString("dd-MM-yyyy");
            }
            return employee;
        }
        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await _context.Employees.Include(x => x.LinkEmployeRoles).ThenInclude(x => x.Roles).Where(x => x.EmployeeID == id).FirstOrDefaultAsync();
            if (employee.Gender != null)
            {
                employee.GenderName = GetAllGenders().Where(x => x.Value == employee.Gender).FirstOrDefault().Name;
            }
            if (employee.LinkEmployeRoles != null)
            {
                var roles = await GetRolesForEmployee(employee);
                if (roles.Count() != 0)
                {
                    employee.Roles = String.Join(", ", roles.Select(x => x.Name));
                    employee.RolesID = roles.Select(x => (int)x.RolesID).ToArray();
                }
            }
            var user_projects = await _organizationService.GetProjectsForEmployee(employee);
            if (user_projects.Count() != 0)
            {
                employee.ProjectsNames = string.Join(Environment.NewLine, user_projects.Select(x => x.Name));
            }
            if (employee.BirthDate.HasValue)
            {
                employee.BirthDateFormated = employee.BirthDate.Value.ToString("dd-MM-yyyy");
            }
            return employee;
        }
        public async Task<(string, string, Employee)> AddEmployee(Employee employee)
        {
            try
            {
                var email =await _context.Employees.Select(x => x.Email).Where(x => x.ToLower() == employee.Email.ToLower()).ToListAsync();
                if (email.Count() == 0)
                {
                    employee.Email = employee.Email.ToLower();
                    string password = GenerateRandomPassword();
                    shortid.Configuration.GenerationOptions options = new shortid.Configuration.GenerationOptions();
                    options.UseNumbers = false;
                    options.UseSpecialCharacters = false;
                    options.Length = 14;
                    string guid = ShortId.Generate(options);
                    bool unique = true;
                    do
                    {
                        var find = await _context.Employees.Select(x => x.GUID).Where(x => x == guid).FirstOrDefaultAsync();
                        if (find == null)
                        {
                            unique = false;
                        }
                        else
                        {
                            guid = ShortId.Generate(options);
                        }
                    } while (unique);
                    employee.GUID = guid;
                    employee.Salt = SaltGenerate();
                    employee.Password = PasswordHash(password, employee.Salt);
                    string basePath = _hostingEnvironment.WebRootPath;
                    FileStream fs = new FileStream(basePath + @"/images/noAvatar.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    employee.Avatar = Extensions.ReadFully(fs);
                    if (employee.RolesID != null)
                    {
                        foreach (var item in employee.RolesID)
                        {
                            await AddEmployeeToRoles(item, new List<int>() { (int)employee.EmployeeID });
                        }
                    }
                    _context.Employees.Add(employee);

                    var EmailMessage = new EmailMessage();
                    EmailMessage.FromAddresses.Add(new EmailAddress { Name = "H&D Ewi", Address = "Administracja@hud.pl" });
                    EmailMessage.ToAddresses.Add(new EmailAddress { Name = employee.Name + " " + employee.Surname, Address = employee.Email });
                    EmailMessage.Subject = _localizer.GetText("AccountCreateSubject");
                    EmailMessage.Content = string.Format(_localizer.GetText("AcountCreateContent"), _navigationManager.BaseUri, employee.Email, password) + _localizer.GetText("MailFooter"); ;

                    _emailService.Send(EmailMessage);

                }
                else
                {
                    return ("UserExistError", _localizer.GetText("EmailAlreadyExist"), await GetEmployee((int)employee.EmployeeID));
                }

                return ("OK", "", await GetEmployee((int)employee.EmployeeID));
            }
            catch (Exception e)
            {

                return ("DBError", e.Message, null);
            }
        }


        public async Task<(string, string, Employee)> UpdateEmployee(Employee employee)
        {
            try
            {
                var email = await _context.Employees.Where(x => x.Email.ToLower() == employee.Email.ToLower() && x.EmployeeID != employee.EmployeeID).ToListAsync();
                if (email.Count() == 0)
                {
                    var context_employee = await _context.Employees.Where(x => x.EmployeeID == employee.EmployeeID).FirstOrDefaultAsync();
                    context_employee.Active = employee.Active;
                    context_employee.BirthDate = employee.BirthDate;
                    context_employee.Email = employee.Email;
                    context_employee.Gender = employee.Gender;
                    context_employee.HolidayCountry = employee.HolidayCountry;
                    context_employee.HolidayCountryState = employee.HolidayCountryState;
                    context_employee.MobileNo = employee.MobileNo;
                    context_employee.Name = employee.Name;
                    context_employee.PersonalNumber = employee.PersonalNumber;
                    context_employee.ShortCut = employee.ShortCut;
                    context_employee.Surname = employee.Surname;
                    _context.Employees.Update(context_employee);
                    await _context.SaveChangesAsync();
                    if (employee.RolesID != null)
                    {
                        var result = await UpdateRolesForEmployee(employee.RolesID, (int) employee.EmployeeID);
                        if (result.Item1 == "DBError")
                        {
                            return ("DBError", result.Item2, await GetEmployee((int)employee.EmployeeID));
                        }
                    }
                }
                else
                {
                    return ("UserExistError", _localizer.GetText("EmailAlreadyExist"), await GetEmployee((int)employee.EmployeeID));
                }
                    

                return ("OK", "", await GetEmployee((int)employee.EmployeeID));
            }
            catch (Exception e)
            {

                return ("DBError", e.Message, null);
            }
        }

        public async Task<(string, string)> DeleteEmployee(Employee employee)
        {
            try
            {
                var link_to_remove = _context.LinkEmployeRoles.Where(x => x.EmployeeID == employee.EmployeeID);
                _context.LinkEmployeRoles.RemoveRange(link_to_remove);
                var employee_to_remove = _context.Employees.Where(x => x.EmployeeID == employee.EmployeeID);
                _context.Employees.RemoveRange(employee_to_remove);
                await _context.SaveChangesAsync();
                return ("OK", "");
            }
            catch (Exception e)
            {
                return ("DBError", e.Message);
            }
        }

        public async Task<byte[]> SaveAvatar(int emp, byte[] file)
        {
            var employee = await _context.Employees.Where(x => x.EmployeeID == emp).FirstOrDefaultAsync();
            employee.Avatar = file;
            await _context.SaveChangesAsync();
            return file;
        }

        public async Task<(string, string, Roles)> AddRole(Roles role)
        {
            try
            {
                _context.Roles.Add(role);
                await _context.SaveChangesAsync();
                if (role.UsersID != null)
                {
                    foreach (var item in role.UsersID)
                    {
                        _context.LinkEmployeRoles.Add(new LinkEmployeRoles { EmployeeID = item, RolesID = role.RolesID });
                    }
                }
                if (role.MenusID != null)
                {
                    foreach (var item in role.MenusID)
                    {
                        _context.LinkRolesMenuItem.Add(new LinkRolesMenuItem { MenuItemID = item, RoleID = role.RolesID });
                    }
                }
                
                await _context.SaveChangesAsync();
                return ("OK", "", GetRole((int)role.RolesID));
            }
            catch (Exception e)
            {

                return ("DBError", e.Message, null);
            }
        }
        public async Task<(string, string, Employee)> UpdateRolesForEmployee(int[] Roles, int employeeid)
        {
            try
            {
                var data_to_change = new List<int>();
                var actual_data = new List<int>();
                var emp = await _context.Employees.Include(x => x.LinkEmployeRoles).Where(x => x.EmployeeID == employeeid).FirstOrDefaultAsync();
                if (Roles != null)
                {
                    data_to_change = Roles.ToList();
                }
                if (emp.LinkEmployeRoles != null)
                {
                    actual_data = emp.LinkEmployeRoles.Select(x => (int)x.RolesID).ToList();
                }
                var remove_data = actual_data.Except(data_to_change).ToList(); //remove data
                var to_remove = _context.LinkEmployeRoles.Where(x => remove_data.Contains((int)x.RolesID) && x.EmployeeID == emp.EmployeeID);
                _context.LinkEmployeRoles.RemoveRange(to_remove);

                var new_data = data_to_change.Except(actual_data).ToList(); //add new_data
                foreach (var item in new_data)
                {
                    _context.LinkEmployeRoles.Add(new LinkEmployeRoles { EmployeeID = emp.EmployeeID, RolesID = item });
                }
                await _context.SaveChangesAsync();
                return ("OK", "", await GetEmployee(emp.GUID));
            }
            catch (Exception e)
            {
                return ("DBError", e.Message, null);
            }
        }
        public async Task<(string, string, Roles)> UpdateRole(Roles role)
        {
            try
            {
                var find_role = await _context.Roles.Where(x => x.RolesID == role.RolesID).FirstOrDefaultAsync();
                find_role.Description = role.Description;
                find_role.Name = role.Name;
                _context.Roles.Update(find_role);

                var data_to_change = new List<int>();
                var actual_data = new List<int>();
                if (role.UsersID != null)
                {
                    data_to_change = role.UsersID.ToList();
                }
                if (role.LinkEmployeRoles != null)
                {
                    actual_data = role.LinkEmployeRoles.Select(x => (int)x.EmployeeID).ToList();
                }

                var remove_data = actual_data.Except(data_to_change).ToList(); //remove data
                var to_remove = _context.LinkEmployeRoles.Where(x => remove_data.Contains((int)x.EmployeeID) && x.RolesID == role.RolesID);
                _context.LinkEmployeRoles.RemoveRange(to_remove);


                var new_data = data_to_change.Except(actual_data).ToList(); //add new_data
                foreach (var item in new_data)
                {
                    _context.LinkEmployeRoles.Add(new LinkEmployeRoles { EmployeeID = item, RolesID = role.RolesID });
                }

                var data_to_change_menus = new List<int>();
                var actual_data_menus = new List<int>();

                if (role.MenusID != null)
                {
                    data_to_change_menus = role.MenusID.ToList();
                }
                if (role.LinkRolesMenuItem != null)
                {
                    actual_data_menus = role.LinkRolesMenuItem.Select(x => (int)x.MenuItemID).ToList();
                }

                remove_data = actual_data_menus.Except(data_to_change_menus).ToList();
                var to_remove_menu = _context.LinkRolesMenuItem.Where(x => remove_data.Contains((int)x.MenuItemID) && x.RoleID == role.RolesID);
                _context.LinkRolesMenuItem.RemoveRange(to_remove_menu);
                
                new_data = data_to_change_menus.Except(actual_data_menus).ToList(); //add new_data
                foreach (var item in new_data)
                {
                    _context.LinkRolesMenuItem.Add(new LinkRolesMenuItem { MenuItemID = item, RoleID = role.RolesID });
                }

                await _context.SaveChangesAsync();
                return ("OK", "", GetRole((int)role.RolesID));
            }
            catch (Exception e)
            {
                return ("DBError", e.Message, GetRole((int)role.RolesID));
            }
        }
        public async Task<(string, string)> DeleteRole(Roles role)
        {
            try
            {
                var link_to_remove = _context.LinkEmployeRoles.Where(x => x.RolesID == role.RolesID);
                _context.LinkEmployeRoles.RemoveRange(link_to_remove);
                var link_to_remove_menu = _context.LinkRolesMenuItem.Where(x => x.RoleID == role.RolesID);
                _context.LinkRolesMenuItem.RemoveRange(link_to_remove_menu);
                var role_to_remove = _context.Roles.Where(x => x.RolesID == role.RolesID);
                _context.Roles.RemoveRange(role_to_remove);
                await _context.SaveChangesAsync();
                return ("OK", "");
            }
            catch (Exception e)
            {
                return ("DBError", e.Message);
            }
        }
            public async Task<(string,string)> RemoveEmployeeFromRoles(int? RolesID, List<int> EmployeeList)
        {
            try
            {
                var to_remove = _context.LinkEmployeRoles.Where(x => EmployeeList.Contains((int)x.EmployeeID) && x.RolesID == RolesID);
                _context.LinkEmployeRoles.RemoveRange(to_remove);
                await _context.SaveChangesAsync();
                return ("OK","");
            }
            catch (Exception e)
            {
                return ("DBError",e.Message);
            }
            
        }

        public async Task<(string, string)> AddEmployeeToRoles(int? RolesID, List<int> EmployeeList)
        {
            try
            {
                foreach (var item in EmployeeList)
                {
                    _context.LinkEmployeRoles.Add(new LinkEmployeRoles { EmployeeID = item, RolesID = RolesID });
                }
                
                await _context.SaveChangesAsync();
                return ("OK", "");
            }
            catch (Exception e)
            {
                return ("DBError", e.Message);
            }

        }

        public async Task<(string, string)> RemoveMenuFromRoles(int? RolesID, List<int> MenuList)
        {
            try
            {
                var to_remove = _context.LinkRolesMenuItem.Where(x => MenuList.Contains((int)x.MenuItemID) && x.RoleID == RolesID);
                _context.LinkRolesMenuItem.RemoveRange(to_remove);
                await _context.SaveChangesAsync();
                return ("OK", "");
            }
            catch (Exception e)
            {
                return ("DBError", e.Message);
            }

        }
        public async Task<(string, string)> AddMenuToRoles(int? RolesID, List<int> MenuList)
        {
            try
            {
                foreach (var item in MenuList)
                {
                    _context.LinkRolesMenuItem.Add(new LinkRolesMenuItem { MenuItemID = item, RoleID = RolesID });
                }

                await _context.SaveChangesAsync();
                return ("OK", "");
            }
            catch (Exception e)
            {
                return ("DBError", e.Message);
            }

        }
        public List<Gender> GetAllGenders()
        {

            List<Gender> gender = new List<Gender>();
            gender.Add(new Gender() { Name = _localizer.GetText("GenderMan"), Value = 0 });
            gender.Add(new Gender() { Name = _localizer.GetText("GenderWoman"), Value = 1 });
            return gender;
        }
        
        public async Task<List<Employee>> GetAllUsers()
        {
            var users = new List<Employee>();
            var emp_collection = await _context.Employees.Include(x=>x.LinkEmployeRoles).ThenInclude(x=>x.Roles).ToListAsync();
            foreach (Employee user in emp_collection)
            {
                if (user.Gender != null)
                {
                    user.GenderName = GetAllGenders().Where(x => x.Value == user.Gender).FirstOrDefault().Name;
                }
                if (user.LinkEmployeRoles != null)
                {
                    var roles =await GetRolesForEmployee(user);
                    if (roles.Count() != 0)
                    {
                        user.Roles = String.Join(", ", roles.Select(x => x.Name));
                        user.RolesID = roles.Select(x => (int)x.RolesID).ToArray();
                    }
                }
                var user_projects = await _organizationService.GetProjectsForEmployee(user);
                if (user_projects.Count() != 0)
                {
                    user.ProjectsNames = string.Join(Environment.NewLine, user_projects.Select(x => x.Name));
                }
                if (user.BirthDate.HasValue)
                {
                    user.BirthDateFormated = user.BirthDate.Value.ToString("dd-MM-yyyy");
                }
                users.Add(user);
            }

            return users.OrderBy(x => x.Name).ThenBy(x => x.Surname).ToList();
        }
    }


    
}
