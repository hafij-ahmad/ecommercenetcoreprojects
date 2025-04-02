using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.infrustructres
{
  public   interface IEmailSender
    {
        Task SendEmailAsync(string Email, string subject, string mgs);
    }
}
