using System.Web.Mvc;
using GenerateAnswerFromController.Infrastructure;

namespace GenerateAnswerFromController.Controllers
{
    public class DerivedController : Controller
    {
        // GET
        // public ActionResult Index()
        // {
        //     return View();
        // }
        
        public ActionResult ProduceOutput()
        {
            return new RedirectResult("/Basic/Index");
        }  
        
        public ActionResult ProduceOutpute()
        {
            return Redirect("/Basic/Index");
        } 
    }
}