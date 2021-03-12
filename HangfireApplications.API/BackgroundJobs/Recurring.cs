using Hangfire;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireApplications.API.BackgroundJobs
{
    public class Recurring
    {
        public static void Job()
        {
            RecurringJob.AddOrUpdate("", () => Debug.Write("Powerful!"), Cron.Minutely());
        }
        public static void Report()
        {
            Debug.WriteLine("Rapor Job çalıştı");
        }
    }
}
