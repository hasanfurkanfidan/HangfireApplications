using HangfireApplications.API.BackgroundJobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireApplications.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatasController : ControllerBase
    {
        [HttpGet]
        public IActionResult SendMail(int userId,string message)
        {
            Recurring.Job();
            return Ok("Job çalıştı");
        }
    }
}
