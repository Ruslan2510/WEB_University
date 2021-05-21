using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module_2.Filter
{
    public class LoggerFilter : ActionFilterAttribute
    {
        private readonly ILogger _logger;
        public LoggerFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("LoggerFilter");
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogWarning("Inside OnActionExecuting method...");
            base.OnActionExecuting(context);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogWarning("Inside OnActionExecuted method...");
            base.OnActionExecuted(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            _logger.LogWarning("Inside OnResultExecuting method...");
            base.OnResultExecuting(context);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            _logger.LogWarning("Inside OnResultExecuted method...");
            base.OnResultExecuted(context);
        }
    }
}
