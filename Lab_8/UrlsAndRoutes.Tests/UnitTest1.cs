using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UrlsAndRoutes.Tests
{
    [TestClass]
    public class RouteTests
    {
        [TestMethod]
        private HttpContextBase CreateHttpContext(string targetUrl = null,
             string httpMethod = "GET")
         {
             // Создать имитированный запрос
             Mock mockRequest = new Mock();
             mockRequest.Setup(m => m.AppRelativeCurrentExecutionFilePath)
                 .Returns(targetUrl);
             mockRequest.Setup(m => m.HttpMethod).Returns(httpMethod);
    
             // Создать имитированный ответ
             Mock mockResponse = new Mock();
             mockResponse.Setup(m => m.ApplyAppPathModifier(
                 It.IsAny())).Returns(s => s);
    
             // Создать имитированный контекст, используя запрос и ответ
             Mock mockContext = new Mock();
             mockContext.Setup(m => m.Request).Returns(mockRequest.Object);
             mockContext.Setup(m => m.Response).Returns(mockResponse.Object);
    
             // Вернуть имитированный контекст
             return mockContext.Object;
         }
    
         private void TestRouteMatch(string url, string controller, string action,
             object routeProperties = null, string httpMethod = "GET")
         {
             // Организация
             RouteCollection routes = new RouteCollection();
             RouteConfig.RegisterRoutes(routes);
    
             // Действие - обработка маршрута
             RouteData result
                 = routes.GetRouteData(CreateHttpContext(url, httpMethod));
    
             // Утверждение
             Assert.IsNotNull(result);
             Assert.IsTrue(TestIncomingRouteResult(result, controller,
                 action, routeProperties));
         }
    
         private bool TestIncomingRouteResult(RouteData routeResult,
             string controller, string action, object propertySet = null)
         {
    
             Func valCompare = (v1, v2) =>
             {
                 return StringComparer.InvariantCultureIgnoreCase
                     .Compare(v1, v2) == 0;
             };
    
             bool result = valCompare(routeResult.Values["controller"], controller)
                           && valCompare(routeResult.Values["action"], action);
    
             if (propertySet != null)
             {
                 PropertyInfo[] propInfo = propertySet.GetType().GetProperties();
                 foreach (PropertyInfo pi in propInfo)
                 {
                     if (!(routeResult.Values.ContainsKey(pi.Name)
                           && valCompare(routeResult.Values[pi.Name],
                               pi.GetValue(propertySet, null))))
                     {
                         result = false;
                         break;
                     }
                 }
             }
    
             return result;
         }
    
         private void TestRouteFail(string url)
         {
             // Организация
             RouteCollection routes = new RouteCollection();
             RouteConfig.RegisterRoutes(routes);
    
             // Действие - обработка маршрута
             RouteData result = routes.GetRouteData(CreateHttpContext(url));
    
             // Утверждение
             Assert.IsTrue(result == null || result.Route == null);
         }
    
        
         [TestMethod]
         public void TestIncomingRoutes()
         {
             TestRouteMatch("~/", "Home", "Index");
             TestRouteMatch("~/Home", "Home", "Index");
             TestRouteMatch("~/Home/Index", "Home", "Index");
             TestRouteMatch("~/Home/CustomVariable", "Home", "CustomVariable");
             TestRouteMatch("~/Home/Index/All", "Home", "Index");
             TestRouteMatch("~/Home/Index/All/Delete", "Home", "Index",
                 new { id = "All", catchcall = "Delete" });
             TestRouteMatch("~/Home/Index/All/Delete/Insert", "Home", "Index",
                 new { id = "All", catchcall = "Delete/Insert" });

             TestRouteFail("~/Home/About");
             TestRouteFail("~/Admin/Index");
         }
    }
}