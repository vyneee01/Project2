using System.Web;
using System.Web.Mvc;

namespace Quản_Lý_Sách
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
