using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Data;
using HUDEwiBlazor.Data.Models;
using HUDEwiBlazor.Interfaces;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

namespace HUDEwiBlazor.Classes
{
    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; } = "";
        public string CCAddress { get; set; } = "";
    }

    public class EmailMessage
     {

        public EmailMessage()
         {
                    ToAddresses = new List<EmailAddress>();
                    FromAddresses = new List<EmailAddress>();
         }

        public List<EmailAddress> ToAddresses { get; set; }
        public List<EmailAddress> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public byte[] Attachment { get; set; }
        public string AttachmentFileName { get; set; }
    }

    

    public class EmailService : IEmailService
    {

        private readonly ApplicationDBContext _context;

        private  EmailSettings _emailConfiguration;
        public EmailService(ApplicationDBContext context)
        {
            this._context = context;
            _emailConfiguration = _context.EmailSettings.FirstOrDefault();
        }

        public List<EmailMessage> ReceiveEmail(int maxCount = 10)
        {
            using (var emailClient = new Pop3Client())
            {
                emailClient.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, true);

                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

                emailClient.Authenticate(_emailConfiguration.PopUsername, _emailConfiguration.PopPassword);

                List<EmailMessage> emails = new List<EmailMessage>();
                for (int i = 0; i < emailClient.Count && i < maxCount; i++)
                {
                    var message = emailClient.GetMessage(i);
                    var emailMessage = new EmailMessage
                    {
                        Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody : message.TextBody,
                        Subject = message.Subject
                    };
                    emailMessage.ToAddresses.AddRange(message.To.Select(x => (MailboxAddress)x).Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));
                    emailMessage.FromAddresses.AddRange(message.From.Select(x => (MailboxAddress)x).Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));
                }

                return emails;
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Send(EmailMessage emailMessage)
        {
            try
            {
                var message = new MimeMessage();
            var cclist = new List<EmailMessage>();
            foreach (var item in emailMessage.ToAddresses.ToList())
            {
                if (IsValidEmail(item.Address) == true)
                {
                    message.To.Add(new MailboxAddress(item.Name, item.Address));
                }
            }
            foreach (var item in emailMessage.ToAddresses.ToList())
            {
                if (IsValidEmail(item.CCAddress) == true)
                {
                    message.Cc.Add(new MailboxAddress(item.Name, item.CCAddress));
                }
            }

            foreach (var item in emailMessage.FromAddresses.ToList())
            {
                if (IsValidEmail(item.Address) == true)
                {
                    message.From.Add(new MailboxAddress(item.Name, item.Address));
                }
            }
            message.Subject = emailMessage.Subject;
            if (emailMessage.Attachment != null)
            {
                MemoryStream ms = new MemoryStream(emailMessage.Attachment);

                var attachment = new MimePart("document", "pdf")
                {
                    Content = new MimeContent(ms),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = emailMessage.AttachmentFileName
                };
                var body = new TextPart(TextFormat.Html)
                {
                    Text = emailMessage.Content
                };
                var multipart = new Multipart("mixed");
                multipart.Add(body);
                multipart.Add(attachment);
                message.Body = multipart;
            }
            else
            {
                //We will say we are sending HTML. But there are options for plaintext etc. 
                message.Body = new TextPart(TextFormat.Html)
                {
                    Text = emailMessage.Content
                };

            }

            //Be careful that the SmtpClient class is the one from Mailkit not the framework!
            using (var emailClient = new SmtpClient())
            {
                //The last parameter here is to use SSL (Which you should!)
                emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, true);

                //Remove any OAuth functionality as we won't be using it. 
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

                emailClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);

                emailClient.Send(message);

                emailClient.Disconnect(true);
            }
        }
            catch (Exception ex)
            {

                //logger.LogError("Błąd Wysyłania Email: " + emailMessage.ToAddresses.First().Address + ", " +emailMessage.Subject+","+emailMessage.Content);
            }
        }
    }
}
