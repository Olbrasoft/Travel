using Olbrasoft.Pagination;
using Olbrasoft.Travel.Business.Facades;
using System.Net;
using System.Threading;
using System.Web.Mvc;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class AccommodationsController : Controller
    {
        private readonly ILocalizedAccommodationsFacade _localizedAccommodationFacade;

        public AccommodationsController(ILocalizedAccommodationsFacade localizedAccommodationFacade)
        {
            _localizedAccommodationFacade = localizedAccommodationFacade;
        }

        // GET: Accommodations
        public ActionResult Index(int page = 1)
        {
            var pageInfo = new PageInfo(10, page);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(1033);

            var pagedListOfLocalizedAccommodation =
                _localizedAccommodationFacade.Get(pageInfo);

            return View(pagedListOfLocalizedAccommodation);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var accommodationId = (int)id;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(1033);

            var accommodationDetailDto = _localizedAccommodationFacade.Get(accommodationId);

            return View(accommodationDetailDto);
        }
    }
}