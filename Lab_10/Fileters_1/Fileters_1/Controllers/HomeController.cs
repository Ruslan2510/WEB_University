using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fileters_1.Infrastructure;

namespace Fileters_1.Controllers
{
    public class HomeController : Controller
    {
        // [Authorize(Users="admin")]
        // public string Index()
        // {
        //     return "Это метод действия Index в контроллере Home";
        // }
        
        [Authorize(Users="admin")]
        public string Index()
        {
            return "Это метод действия Index в контроллере Home";
        }

        // [GoogleAuth]
        // public string List()
        // {
        //     return "Это метод действия List в контроллере Home";
        // }
        
        [GoogleAuth]
        [Authorize(Users="alex@google.com")]
        public string List()
        {
            return "Это метод действия List в контроллере Home";
        }

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
        
        [HandleError(ExceptionType=typeof(ArgumentOutOfRangeException),
            View="RangeError")]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return String.Format("Значение ID: {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }
        
        // [CustomAction]
        // public string FilterTest()
        // {
        //     return "Это метод действия FilterTest в контроллере Home";
        // }
        //
        // [ProfileAction]
        // public string FilterTest()
        // {
        //     return "Это метод действия FilterTest в контроллере Home";
        // }
        
        // [ProfileAction]
        // [ProfileResult]
        // public string FilterTest()
        // {
        //     return "Это метод действия FilterTest в контроллере Home";
        // }
        
        // [ProfileAction]
        // [ProfileResult]
        // [ProfileAll]
        // public string FilterTest()
        // {
        //     return "Это метод действия FilterTest в контроллере Home";
        // }
        
        private Stopwatch timer;
        public string FilterTest()
        {
            return "Это метод действия FilterTest в контроллере Home";
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
                string.Format("<div>Общее время: {0}</div>",
                    timer.Elapsed.TotalSeconds));
        }
    }
}