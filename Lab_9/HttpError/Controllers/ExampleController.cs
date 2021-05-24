using System.Web.Mvc;

namespace HttpError.Controllers
{
    public class ExampleController : Controller
    {
        // public HttpStatusCodeResult StatusCode()
        // {
        //     // Ошибка 404 - URL не может быть обслужен
        //     return new HttpStatusCodeResult(404, "Страница не найдена");
        // }
        
        // public HttpStatusCodeResult StatusCode()
        // {
        //     // Ошибка 404 - URL не может быть обслужен
        //     return HttpNotFound();
        // }
        
        public HttpStatusCodeResult StatusCode()
        {
            return new HttpUnauthorizedResult();
        }
    }
}