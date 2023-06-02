using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero.Utility
{
    public class EmailSender : IEmailSender
    { 
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //send email mantigi buraya eklenecek ileride
            return Task.CompletedTask;
        }
    }
}
