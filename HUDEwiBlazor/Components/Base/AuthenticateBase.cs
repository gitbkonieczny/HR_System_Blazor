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

namespace HUDEwiBlazor.Components
{
    public class AuthenticateBase: ComponentBase
    {
        public LoginModel loginModel = new LoginModel();
        public EmailModel emailModel = new EmailModel();
        public PasswordChangeModel passwordChangeModel = new PasswordChangeModel();
        public PasswordOptions PasswordOptions { get; }

        public string authorization_result = null;

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

       
        [Parameter]
        public Expression<Func<LoginModel>> For { get; set; }

        [Parameter]
        public string LinkCode { get; set; }

        [Parameter]
        public string Site { get; set; }

        public bool LinkExist { get; set; } = false;
       
        protected override async Task OnInitializedAsync()
        {
            if (Site == "LoginPasswordChange")
            {
                LinkExist = await _security.CheckLinkExist(LinkCode);
            }
        }



        public void GoToHomePage()
        {
            navigationManager.NavigateTo("/");
        }
        public async Task ValidFormSubmitted(EditContext editContext)
        {
            authorization_result = null;
            var security_result = await _security.Authenticate(loginModel.email, loginModel.password);
            if (security_result.Item1)
            {
                await ProtectedSessionStore.SetAsync("GUID", security_result.Item2);
                navigationManager.NavigateTo("/main");
            }
            else
            {
                authorization_result = "Nieprawidłowy login/hasło";
                loginModel.email = null;
                loginModel.password = null;
            }
        }
        public void InvalidFormSubmitted(EditContext editContext)
        {
            authorization_result = null;
        }

        public async Task PasswordValidFormSubmitted(EditContext editContext)
        {
            authorization_result = null;
            if (await _security.IsEmail(emailModel.email))
            {
                var link = await _security.SaveLink(emailModel.email);
                var user = await _context.Employees.Where(x => x.Email == emailModel.email).FirstOrDefaultAsync();
                var EmailMessage = new EmailMessage();
                EmailMessage.FromAddresses.Add(new EmailAddress { Name = "H&D Ewi", Address = "Administracja@hud.pl" });

                EmailMessage.ToAddresses.Add(new EmailAddress { Name = user.Name + " " + user.Surname, Address = user.Email });
                EmailMessage.Subject = "Wysłano prośbę o wygenerowanie nowego hasła.";
                EmailMessage.Content = "Aby zmienić hasło kliknij w link -> <a href=\""+navigationManager.BaseUri+"LoginPasswordChange/" + link.Link + "\">Zmiana Hasła</a>" +
                         "<BR /><BR /><p style=\"font-size:8px\">UWAGA: Wiadomość została wygenerowana automatycznie, prosimy na nią nie odpowiadać.<BR />" +
                         "W przypadku pytań lub wątpliwości, prosimy o kontakt za pomocą drogi mailowej na adres: Administracja@hud.pl<BR /><BR />" +
                         "Wiadomość przeznaczona jest wyłącznie dla jej zamierzonego adresata i może zawierać informacje zastrzeżone i prawnie chronione.<BR />" +
                         "Jeżeli otrzymałeś ją przez pomyłkę, prosimy o poinformowanie nas o tym fakcie za pomocą ww. e - maila kontaktowego.</p>";

                _emailService.Send(EmailMessage);
                navigationManager.NavigateTo("/LoginPasswordSendLinkConfirmation");
            }
            else
            {
                authorization_result = "Ten adress e-mail nie istnieje w HuDEwi!";
                emailModel.email = null;
            }
        }
        public void PasswordInvalidFormSubmitted(EditContext editContext)
        {
            authorization_result = null;
        }


        public async Task ChangePasswordValidFormSubmitted(EditContext editContext)
        {
            if (passwordChangeModel.password1 == passwordChangeModel.password2)
            {
                var result = await _security.ChangePassword(passwordChangeModel.password1, LinkCode);
                if (result)
                {
                    navigationManager.NavigateTo("/LoginPasswordChangeConfirmation");
                }
            }else
            {
                authorization_result = "Hasła są różne!";
            }

        }

        public void ChangePasswordInvalidFormSubmitted(EditContext editContext)
        {
            authorization_result = null;
        }
    }

    public class LoginModel
    {
        [EmailAddress(ErrorMessage ="Nieprawidłowy adres e-mail")]
        [Required(ErrorMessage ="Wymagane")]
        public string email { get; set; }
        [Required(ErrorMessage = "Wymagane")]
        public string password { get; set; }
    }
    public class EmailModel
    {
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail")]
        [Required(ErrorMessage = "Wymagane")]
        public string email { get; set; }
    }

    public class PasswordChangeModel
    {
        [Required(ErrorMessage = "Wymagane")]
        [StringLength(100, ErrorMessage = "Hasło musi składać się z min {2} i max {1} znaków.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string password1 { get; set; }

        [Required(ErrorMessage = "Wymagane")]
        [StringLength(100, ErrorMessage = "Hasło musi składać się z min {2} i max {1} znaków.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string password2 { get; set; }

    }
}
