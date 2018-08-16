using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Olbrasoft.Shared;
using Olbrasoft.Travel.BusinessLogicLayer;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccommodationsFacade _accommodationFacade;

        public HomeController(IAccommodationsFacade accommodationFacade)
        {
            _accommodationFacade = accommodationFacade;
        }

        // GET: Home
        public ActionResult Index(int page = 1)
        {
            var pageInfo = new PageInfo(3, page);
            return View(_accommodationFacade.Get(pageInfo));
        }
    }
}