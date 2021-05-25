using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Fileters_1.Controllers
{
    public class AdminController : Controller
    {
        // [Authorize(Roles = "admin")] // Применяется ко всем методам действий
        // public class AdminController : Controller
        // {
        //     [ShowMessage]
        //     [OutputCache(Duration = 60)] // Применяется только к этому действию
        //     public ViewResult Index()
        //     {
        //         // ...
        //     }
        // }

        // [Authorize]
        // public ViewResult Edit(int gameId)
        // {
        //     // ... остальная часть метода действия
        // }
        //
        // [Authorize]
        // public ActionResult Edit(Game game, HttpPostedFileBase image = null)
        // {
        //     // ... остальная часть метода действия
        // }

        // ... другие методы действий
    }
}