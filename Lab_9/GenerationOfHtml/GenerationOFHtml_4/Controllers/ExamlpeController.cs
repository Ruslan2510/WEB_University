using System;
using Microsoft.AspNetCore.Mvc;

namespace GenerationOFHtml_4.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Привет";
            ViewBag.Date = DateTime.Now;
            return View();
        }
    }
}