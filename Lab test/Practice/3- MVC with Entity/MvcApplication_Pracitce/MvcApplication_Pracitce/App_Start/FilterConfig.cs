using System.Web;
using System.Web.Mvc;

namespace MvcApplication_Pracitce
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}