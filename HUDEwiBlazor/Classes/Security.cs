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

namespace HUDEwiBlazor.Classes
{
    public class Security:ISecurity
    {
        private readonly ApplicationDBContext _context;

        public Security(ApplicationDBContext context)
        {
            this._context = context;
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
    }


    
}
