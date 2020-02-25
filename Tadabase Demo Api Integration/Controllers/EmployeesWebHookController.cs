using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tadabase_Demo_Api_Integration.Controllers
{
    [Route("[controller]")]
    public class EmployeesWebHookController : Controller
    {
        [HttpPost("")]
        public IActionResult Index(object model)
        {
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult Logs()
        {
            return View();
        }
    }
}