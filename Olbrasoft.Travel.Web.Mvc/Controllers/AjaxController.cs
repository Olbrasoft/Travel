using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Shared;
using Olbrasoft.Shared.UnitTest;
using Olbrasoft.Travel.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Olbrasoft.Travel.Data.Entity.Queries;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class AjaxController : Controller
    {
        // Ajax Paging
        public ViewResult Index()
        {
            return View();
        }

        // Ajax Paging (cont'd)
        public ActionResult AjaxPage(int page = 1)
        {
            IPageInfo pageInfo = new PageInfo(10, page);
            ILanguageService languageService = new ThreadCultureLanguageService();

            var q = new AccommodationPagedQuery(new TravelContext().Accommodations, pageInfo, languageService);

            var accommodations = q.Execute().AsPagedList();

            return Json(new
            {
                names = accommodations.ToArray(),
                pager = accommodations.GetMetaData()
            }, JsonRequestBehavior.AllowGet);
        }
    }
}