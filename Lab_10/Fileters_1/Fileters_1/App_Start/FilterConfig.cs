using System.Web;
using System.Web.Mvc;
using Fileters_1.Infrastructure;

namespace Fileters_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ProfileAllAttribute());
        }
    }
}