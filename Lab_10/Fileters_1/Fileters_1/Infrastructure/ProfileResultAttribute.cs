﻿using System.Diagnostics;
using System.Web.Mvc;

namespace Fileters_1.Infrastructure
{
    public class ProfileResultAttribute : FilterAttribute, IResultFilter
    {
        private Stopwatch timer;

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
                string.Format("<div>Время обработки результата: {0:F6}</div>",
                    timer.Elapsed.TotalSeconds));
        }
    }
}