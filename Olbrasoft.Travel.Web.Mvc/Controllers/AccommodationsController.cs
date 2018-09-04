using Olbrasoft.Pagination;
using Olbrasoft.Travel.Business.Facades;
using System.Net;
using System.Threading;
using System.Web.Mvc;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class AccommodationsController : Controller
    {
        // GET: Accommodations
        private readonly IAccommodationsFacade _accommodationFacade;

        public AccommodationsController(IAccommodationsFacade accommodationFacade)
        {
            _accommodationFacade = accommodationFacade;
        }

        // GET: Home
        public ActionResult Index(int page = 1)
        {
            var pageInfo = new PageInfo(10, page);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(1033);

            var pagedListOfAccommodation =
                _accommodationFacade.Get(pageInfo);

            return View(pagedListOfAccommodation);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View(id);
        }
    }
}