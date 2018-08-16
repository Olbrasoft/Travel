using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        public ActionResult Index()
        {
            return View();
        }
    }
}