using System.Web.Mvc;
using ControllersFabric_MVC.Models;

namespace PerformanceImprovement.Controllers
{
    public class FastController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Fast ",
                ActionName = "Index"
            });
        }
    }
}