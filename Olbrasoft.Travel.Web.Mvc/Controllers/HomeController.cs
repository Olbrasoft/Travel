using System.Threading;
using System.Web.Mvc;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Business.Facades;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccommodationsFacade _accommodationFacade;

        public HomeController(IAccommodationsFacade accommodationFacade)
        {
            _accommodationFacade = accommodationFacade;
        }

        // GET: Home
        public ActionResult Index(int page = 1)
        {
            var pageInfo = new PageInfo(10, page);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(1033);

            var pagedListOfAccommodation =
                 _accommodationFacade.AccommodationDataTransferObjects(pageInfo);

            return View(pagedListOfAccommodation);
        }
    }
}