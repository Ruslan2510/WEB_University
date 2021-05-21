using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Module_2.Filter
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Console.WriteLine("Before Action Execution");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Console.WriteLine("After Action Execution");
        }
    }
}
