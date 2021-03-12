using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireApplications.API.Services
{
    public interface IEmailSender
    {
        Task Sender(int userId, string message);
    }
}
