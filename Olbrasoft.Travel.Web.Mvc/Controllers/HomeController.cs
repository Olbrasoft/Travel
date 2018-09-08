using System.Threading;
using System.Web.Mvc;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Business.Facades;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILocalizedAccommodationsFacade _localizedAccommodationFacade;

        public HomeController(ILocalizedAccommodationsFacade localizedAccommodationFacade)
        {
            _localizedAccommodationFacade = localizedAccommodationFacade;
        }

        // GET: Home
        public ActionResult Index(int page = 1)
        {
            var pageInfo = new PageInfo(10, page);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(1033);

            var pagedListOfAccommodation =
                 _localizedAccommodationFacade.Get(pageInfo);

            return View(pagedListOfAccommodation);
        }
    }
}