using System.Web.Mvc;
using ControllersFabric_MVC.Models;

namespace ActionActivator.Controllers
{
    public class CustomerController : Controller
    {
        [ActionName("Enumerate")]
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