using System.Web;
using System.Web.Mvc;

namespace MissionSite_Project1_Team1_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
