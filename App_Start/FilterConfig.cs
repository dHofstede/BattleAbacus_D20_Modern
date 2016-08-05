using System.Web;
using System.Web.Mvc;

namespace BattleAbacus_D20_Modern
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
