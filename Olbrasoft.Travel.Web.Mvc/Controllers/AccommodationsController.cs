using Olbrasoft.Pagination;
using Olbrasoft.Travel.Business;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class AccommodationsController : Controller
    {
        private readonly IAccommodations _accommodations;

        public AccommodationsController(IAccommodations accommodations)
        {
            _accommodations = accommodations;
        }


        // GET: Accommodations
        public async Task<ActionResult> Index(int page = 1)
        {
            var pageInfo = new PageInfo(10, page);
            
            var accommodationsItems = await _accommodations.GetAsync(pageInfo, 1033,
                localizedAccommodations =>
                    localizedAccommodations.OrderBy(p => p.Accommodation.SequenceNumber).ThenBy(p => p.Id));

            return View(accommodationsItems.AsPagedList(pageInfo));
        }

         
        public async Task<ActionResult> Detail(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var accommodationDetail = await _accommodations.GetAsync((int)id, 1033);

            return View(accommodationDetail);
        }
    }
}