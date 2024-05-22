using System.Web;
using System.Web.Mvc;

namespace ApiRest_CuotaSemestral
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
