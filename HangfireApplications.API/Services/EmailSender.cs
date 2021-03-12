using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireApplications.API.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async  Task Sender(int userId, string message)
        {
            var apiKey = Environment.GetEnvironmentVariable(_configuration.GetSection("Api")["SendGrid"]);
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("furkanfidanafyon@gmail.com", "Furkan Fidan");
            var subject = "Site bilgilendirme";
            var to = new EmailAddress("h.furkanfidan1999@gmail.com", "Furkan Fidan");
            var htmlContent = "<strong>Hey</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, null,htmlContent);
            var response =await  client.SendEmailAsync(msg);
        }
    }
}
