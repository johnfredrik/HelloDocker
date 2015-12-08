using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace HelloDocker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var host = HttpContext.Request.Host.Value;
            ViewData["Host"] = host;
            return View();
            
        }
        
    }
}
