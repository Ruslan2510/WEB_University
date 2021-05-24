using System;
using Microsoft.AspNetCore.Mvc;

namespace RedirectionMVC.Controllers
{
    public class ExampleController : Controller
    {
        // GET
        // public IActionResult Index()
        // {
        //     return View();
        // }
        
        public RedirectResult Redirect()
        {
            return Redirect("/Basic/Index");
        }
        
        public RedirectResult RedirectParametr()
        {
            return RedirectPermanent("/Basic/Index");
        }
        
        public RedirectToRouteResult RedirectRoute()
        {
            return RedirectToRoute(new
            {
                controller = "Basic",
                action = "Index",
                id = "MyId"
            });
        }
        
        // public ViewResult Index()
        // {
        //     ViewBag.Message = TempData["Message"];
        //     ViewBag.Date = TempData["Date"];
        //     return View();
        // }
        //
        // public RedirectToRouteResult RedirectRoute()
        // {
        //     TempData["Message"] = "Привет";
        //     TempData["Date"] = DateTime.Now;
        //     return RedirectToAction("Index");
        // }
    }
}