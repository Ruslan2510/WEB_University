using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Module_2.Filter;
using Module_2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Module_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ServiceFilter(typeof(LoggerFilter))]
        public IEnumerable<string> Get()
        {
            _logger.LogInformation("Inside HttpGet action method...");
            return new string[] { "Joydip", "Michael", "Anand", "Steve" };
        }


        [SimpleResourceFilter]
        [CustomActionFilter]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name, int age)
        {
            return Content($"{name} - {age}");
        }

    }
}
