using System;
using System.Web.Mvc;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class AjaxController : Controller
    {
        // Ajax PageInfo
        public ViewResult Index()
        {
            return View();
        }

        // Ajax PageInfo (cont'd)
        public ActionResult AjaxPage(int page = 1)
        {
            //IPageInfo pageInfo = new PageInfo(10, page);
            //ILanguageService languageService = new ThreadCultureLanguageService();

            //var q = new AccommodationPagedQuery(new TravelDatabaseContext().Accommodations, pageInfo, languageService);

            //var accommodations = q.Execute().AsPagedList();

            //return Json(new
            //{
            //    names = accommodations.ToArray(),
            //    pager = accommodations.GetMetaData()
            //}, JsonRequestBehavior.AllowGet);

            throw new NotImplementedException();
        }
    }
}