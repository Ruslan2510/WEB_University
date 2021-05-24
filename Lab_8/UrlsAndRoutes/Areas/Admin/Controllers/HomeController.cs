using System.Web.Mvc;

namespace UrlsAndRoutes.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}