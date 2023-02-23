using System.Web;
using System.Web.Mvc;

namespace Assignment2_N01517224
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
