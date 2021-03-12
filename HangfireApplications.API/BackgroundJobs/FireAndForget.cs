using Hangfire;
using HangfireApplications.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireApplications.API.BackgroundJobs
{
    public class FireAndForget
    {
        public static  void EmailSendToUserJob(int userId,string message)
        {
            BackgroundJob.Enqueue<IEmailSender>(p => p.Sender(userId, message));
        }
    }
}
