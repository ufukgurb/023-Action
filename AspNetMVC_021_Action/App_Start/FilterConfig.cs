using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_021_Action
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
