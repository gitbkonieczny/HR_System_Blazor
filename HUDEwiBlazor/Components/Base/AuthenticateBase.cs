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
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Builder;
using Syncfusion.Blazor;

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
        IOptions<RequestLocalizationOptions> LocOptions { get; set; }
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
        [Inject]
        protected ISyncfusionStringLocalizer Localizer { get; set; }
        //[Parameter]
        //public Expression<Func<LoginModel>> For { get; set; }
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

      

        public string email_validation_message { get; set; }
        public string password_validation_message { get; set; }
        public string password_validation_1 { get; set; }
        public string password_validation_2 { get; set; }
        public void GoToHomePage()
        {
            navigationManager.NavigateTo("/");
        }
        public async Task ValidFormSubmitted(EditContext editContext)
        {
            authorization_result = null;
            email_validation_message = null;
            password_validation_message = null;

            LoginModel model = (LoginModel)editContext.Model;
            if (model.email == "" || model.email == null)
                email_validation_message = Localizer.GetText("Required");
            if (model.password == "" || model.password == null)
                password_validation_message = Localizer.GetText("Required");

            if (email_validation_message != null || password_validation_message != null)
            {
                return;
            }


            var security_result = await _security.Authenticate(loginModel.email, loginModel.password);
            if (security_result.Item1)
            {
                await ProtectedSessionStore.SetAsync("GUID", security_result.Item2);
                var Locale = await ProtectedLocalStorage.GetAsync<string>("Culture");
                if (Locale != null && Locale != "Select Culture")
                {
                    LocOptions.Value.SetDefaultCulture(Locale);

                }

                navigationManager.NavigateTo("/main",forceLoad:true);
            }
            else
            {
                
                authorization_result = Localizer.GetText("WrongPassword");
                loginModel.email = null;
                loginModel.password = null;
            }
        }
        public void InvalidFormSubmitted(EditContext editContext)
        {
            
        }

        public async Task PasswordValidFormSubmitted(EditContext editContext)
        {
            authorization_result = null;
            email_validation_message = null;

            EmailModel model = (EmailModel)editContext.Model;
            if (model.email == "" || model.email == null)
            {
                email_validation_message = Localizer.GetText("Required");
                return;
            }


            if (await _security.IsEmail(emailModel.email))
            {
                var link = await _security.SaveLink(emailModel.email);
                var user = await _context.Employees.Where(x => x.Email == emailModel.email).FirstOrDefaultAsync();
                var EmailMessage = new EmailMessage();
                EmailMessage.FromAddresses.Add(new EmailAddress { Name = "H&D Ewi", Address = "Administracja@hud.pl" });

                EmailMessage.ToAddresses.Add(new EmailAddress { Name = user.Name + " " + user.Surname, Address = user.Email });
                EmailMessage.Subject = Localizer.GetText("MailSubjectPasswordCreate");
                EmailMessage.Content = Localizer.GetText("MailHrefLink") +" <a href=\""+navigationManager.BaseUri+"LoginPasswordChange/" + link.Link + "\">"+Localizer.GetText("ChangePassword") +" </a>" 
                    +Localizer.GetText("MailFooter");

                _emailService.Send(EmailMessage);
                navigationManager.NavigateTo("/LoginPasswordSendLinkConfirmation");
            }
            else
            {
                authorization_result = Localizer.GetText("EmailNotExist");
                emailModel.email = null;
            }
        }
        public void PasswordInvalidFormSubmitted(EditContext editContext)
        {
            authorization_result = null;
        }


        public async Task ChangePasswordValidFormSubmitted(EditContext editContext)
        {
            password_validation_1 = null;
            password_validation_2 = null;
            PasswordChangeModel model = (PasswordChangeModel)editContext.Model;
            if (model.password1 == "" || model.password1 == null)
                password_validation_1 = Localizer.GetText("Required");
            if (model.password2 == "" || model.password2 == null)
                password_validation_2 = Localizer.GetText("Required");

            if (password_validation_1 != null || password_validation_2 != null)
            {
                return;
            }
            if (passwordChangeModel.password1 == passwordChangeModel.password2)
            {
                var result = await _security.ChangePassword(passwordChangeModel.password1, LinkCode);
                if (result)
                {
                    navigationManager.NavigateTo("/LoginPasswordChangeConfirmation");
                }
            }else
            {
                authorization_result = Localizer.GetText("DiffrentPassword");
                
            }

        }

        public void ChangePasswordInvalidFormSubmitted(EditContext editContext)
        {
            authorization_result = null;
        }
    }

   

    public class LoginModel
    {

        public string email { get; set; }
        public string password { get; set; }
    }
    public class EmailModel
    {
        public string email { get; set; }
    }

    public class PasswordChangeModel
    {
        public string password1 { get; set; }

        public string password2 { get; set; }

    }
}
