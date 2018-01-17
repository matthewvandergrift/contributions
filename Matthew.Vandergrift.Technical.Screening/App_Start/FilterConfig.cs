using System.Web;
using System.Web.Mvc;

namespace Matthew.Vandergrift.Technical.Screening
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
