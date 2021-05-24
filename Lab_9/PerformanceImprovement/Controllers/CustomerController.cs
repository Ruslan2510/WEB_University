using System.Web.Mvc;
using ControllersFabric_MVC.Models;

namespace ControllersFabric_MVC.Controllers
{
    public class CustomerController : Controller
    {
        public ViewResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "Index"
            });
        }

        public ViewResult List()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "List"
            });
        }
    }
}