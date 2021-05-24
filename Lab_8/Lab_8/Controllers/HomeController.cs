using System.Web.Mvc;
using Lab_8.Models;

namespace Lab_8.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product {
            ProductId = 1,
            Name = "Бумага",
            Description = "Акция Microsoft Corp.",
            Category = "Cost paper",
            Price = 275M
        };
        public ActionResult Index()
        {
            return View(myProduct);
        }
        
        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }

        public ActionResult DemoExpression() {

            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        
        public ActionResult DemoArray() {
            Product[] array = {
                new Product {Name = "Бумага Google", Price = 275M},
                new Product {Name = "Бумага Yandex", Price = 48.95M},
                new Product {Name = "Бумага Amazon", Price = 19.50M},
                new Product {Name = "Бумага Apple", Price = 34.95M}
            };
            return View(array);
        }
    }
}