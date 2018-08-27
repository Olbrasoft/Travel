using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.UnitTest;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Query;

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
		public ActionResult AjaxPage(int page=1)
		{
            IPageInfo pageInfo = new PageInfo(10, page);
		    ILanguageService languageService = new ThreadCultureLanguageService();

		    var q = new AccommodationPagedQuery(new TravelContext().Accommodations, pageInfo, languageService);

		    var accommodations = q.Execute();
            

            return Json(new
			{
				names = accommodations.ToArray(),
				pager = accommodations.GetMetaData()
			}, JsonRequestBehavior.AllowGet);

		}
    }
}
