using System.Threading;
using System.Web.Mvc;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int page = 1)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(1033);

            return View();
        }
    }
}