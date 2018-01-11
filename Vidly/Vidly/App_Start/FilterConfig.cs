using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Autenticazione globale dell'applicazione (passaggio veramente restrittivo).
            filters.Add(new AuthorizeAttribute());

        }
    }
}
