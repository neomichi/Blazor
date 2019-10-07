using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Data.Service
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.Run(() => { });
        }
    }
}
