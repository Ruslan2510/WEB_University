using System.Web.Mvc;
using ActionActivator.Infrastructure;

namespace ActionActivator.Controllers
{
    public class ActionInvokerController : Controller
    {
        public ActionInvokerController()
        {
            this.ActionInvoker = new CustomActionInvoker();
        }
    }
}