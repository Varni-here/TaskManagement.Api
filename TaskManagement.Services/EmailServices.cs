using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.EmailSettings;
using TaskManagement.Core.Interfaces;

namespace TaskManagement.Services
{
    public class EmailServices : IEmailService
    {
        private readonly EmailSettings _emailSettings;
        public EmailServices(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var mail = new MailMessage()
            {
                From = new MailAddress(_emailSettings.User, _emailSettings.DisplayName),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            mail.To.Add(to);

            var smtpClient = new SmtpClient(_emailSettings.Host, _emailSettings.Port)
            {
                Credentials = new NetworkCredential(_emailSettings.User,_emailSettings.Password),
                EnableSsl = _emailSettings.EnableSSL
            };

            await smtpClient.SendMailAsync(mail);

        }
    }
}