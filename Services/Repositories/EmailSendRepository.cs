using EcommerceWebAppAngularjs.Services.infrustructres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.Repositories
{
    public class EmailSendRepository : IEmailSender
    {
        public async Task SendEmailAsync(string Email, string subject, string mgs)
        {
            var mailMessage = new MailMessage("your-email@example.com", Email, subject, mgs);
            var smtpClient = new SmtpClient("smtp.example.com");

            // Asynchronous email sending
            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
