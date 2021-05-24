using Microsoft.AspNetCore.Mvc;

namespace RedirectionMVC.Controllers
{
    public class BasicController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}