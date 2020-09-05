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
    }
}
