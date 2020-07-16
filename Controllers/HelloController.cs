using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            ViewBag.person = name;
            return View();
        }
    }
}
