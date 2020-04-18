using System.Web;
using System.Web.Mvc;

namespace Ribbonwood_Gaming_Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
