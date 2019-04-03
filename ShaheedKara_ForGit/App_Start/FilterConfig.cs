using System.Web;
using System.Web.Mvc;

namespace ShaheedKara_ForGit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
