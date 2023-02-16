using System.Web;
using System.Web.Mvc;

namespace Mini_MVC_Entity_project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}