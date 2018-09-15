using System.Linq;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Business.Facades;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
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
        public async Task<ActionResult> Index(int page = 1)
        {
            var pageInfo = new PageInfo(10, page);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(1033);

            var pagedListOfLocalizedAccommodation = await 
                _localizedAccommodationFacade.GetAsync(pageInfo,p=>p.OrderBy(la=>la.Accommodation.SequenceNumber).ThenBy(la=>la.Id));

            return View(pagedListOfLocalizedAccommodation);
        }

        public async Task<ActionResult> Detail(int? id)
        {
        
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var accommodationId = (int)id;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(1033);

            var accommodationDetailDto = await _localizedAccommodationFacade.GetAsync(accommodationId);

            return View( accommodationDetailDto);

        }
    }
}