using Olbrasoft.Shared;
using Olbrasoft.Shared.UnitTest;
using Olbrasoft.Travel.Data.Entity;
using System.Threading;
using System.Web.Mvc;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Travel.Data.Entity.Queries;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class AccommodationsController : Controller
    {
        // GET: Accommodations
        public ActionResult Index(int page = 1)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-Us");

            IPageInfo pageInfo = new PageInfo(10, page);

            ILanguageService languageService = new ThreadCultureLanguageService();

            var q = new AccommodationPagedQuery(new TravelContext().Accommodations, pageInfo, languageService);

            var pagedAccommodations = q.Execute().AsPagedList();

            return View(pagedAccommodations);
        }
    }
}