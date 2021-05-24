using GenerationOFHtml_4.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Tests
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
        //     ViewResult result = controller.Index();
        //
        //     // Утверждение - проверка результата
        //     Assert.AreEqual("Homepage", result.ViewName);
        // } 
        
        // [TestMethod]
        // public void ViewSelectionTest()
        // {
        //     // Организация - создание контроллера
        //     ExampleController controller = new ExampleController();
        //
        //     // Действие - вызов метода действия
        //     ViewResult result = controller.Index();
        //
        //     // Утверждение - проверка результата
        //     // Assert.AreEqual("", result.ViewName);
        //     Assert.IsInstanceOfType(result.ViewData.Model, typeof(System.DateTime));
        // }
        
        [TestMethod]
        public void ControllerTest()
        {
            // Организация - создание контроллера
            ExampleController controller = new ExampleController();

            // Действие - вызов метода действия
            ViewResult result = controller.Index();

            // Утверждение - проверка результата
            Assert.AreEqual(null, result.ViewName);
            // Assert.AreEqual("Привет", result.ViewName);
        }
    }
}