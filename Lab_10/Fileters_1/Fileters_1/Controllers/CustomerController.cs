using System.Web.Mvc;
using Fileters_1.Infrastructure;

namespace Fileters_1.Controllers
{
    // public class CustomerController : Controller
    // {
    //     [SimpleMessage(Message="A")]
    //     [SimpleMessage(Message = "Б")]
    //     public string Index()
    //     {
    //         return "Это контроллер Customer";
    //     }
    // }

    // public class CustomerController : Controller
    // {
    //     [SimpleMessage(Message="A", Order=2)]
    //     [SimpleMessage(Message = "Б", Order=1)]
    //     public string Index()
    //     {
    //         return "Это контроллер Customer";
    //     }
    // }
    
    [SimpleMessage(Message="A")]
    public class CustomerController : Controller
    {
    public string Index()
        {
            return "Это контроллер Customer";
        }

        // [SimpleMessage(Message = "Б")]
        // public string OtherMethod()
        // {
        //     return "Это метод действия OtherMethod в контроллере Customer";
        // }
        
        [CustomOverrideActionFilters]
        [SimpleMessage(Message = "Б")]
        public string OtherMethod()
        {
            return "Это метод действия OtherMethod в контроллере Customer";
        }
    }
}