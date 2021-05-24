using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedirectionMVC.Controllers;

namespace Redirection.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // [TestMethod]
        // public void ControllerTest()
        // {
        //     // Организация - создание контроллера
        //     ExampleController controller = new ExampleController();
        //
        //     // Действие - вызов метода действия
        //     RedirectResult result = controller.Redirect();
        //
        //     // Утверждение - проверка результата
        //     Assert.IsTrue(result.Permanent);
        //     Assert.AreEqual("/Basic/Index", result.Url);
        // }
        
        [TestMethod]
        public void ControllerTest()
        {
            // Организация - создание контроллера
            ExampleController controller = new ExampleController();

            // Действие - вызов метода действия
            RedirectToRouteResult result = controller.RedirectRoute();

            // Утверждение - проверка результата
            Assert.IsFalse(result.Permanent);
            Assert.AreEqual("Basic", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("MyId", result.RouteValues["id"]);
        }
    }
}