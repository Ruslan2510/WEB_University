using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlFroms_.Models;

namespace HtmlFroms_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult CreateUser(User User)
        {
            return View(User);
        }
    }
}