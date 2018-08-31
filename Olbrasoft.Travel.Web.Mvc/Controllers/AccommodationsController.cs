using Olbrasoft.Shared;
using Olbrasoft.Shared.Linq;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.UnitTest;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Query;
using System.Threading;
using System.Web.Mvc;

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