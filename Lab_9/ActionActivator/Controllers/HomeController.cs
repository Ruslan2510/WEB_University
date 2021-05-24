using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionActivator.Infrastructure;
using ControllersFabric_MVC.Models;

namespace ActionActivator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Home",
                ActionName = "Index"
            });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result
            {
                ControllerName = "Home",
                ActionName = "LocalIndex"
            });
        }
        
        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write(string.Format("Вы запросили метод действия <b>{0}</b>", actionName));
        }
        
        
        // public ActionResult Index()
        // {
        //     return View();
        // }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}