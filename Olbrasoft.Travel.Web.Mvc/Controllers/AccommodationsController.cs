using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.UnitTest;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Query;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class AccommodationsController : Controller
    {
        // GET: Accommodations
        public ActionResult Index(int page = 1)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-Us");

            IPageInfo pageInfo = new PageInfo(10,page);

            ILanguageService languageService = new ThreadCultureLanguageService();

            var q = new AccommodationPagedQuery(new TravelContext().Accommodations, pageInfo, languageService); 
            
            var accommodations = q.Execute();

            return View(accommodations);
        }

    }
}