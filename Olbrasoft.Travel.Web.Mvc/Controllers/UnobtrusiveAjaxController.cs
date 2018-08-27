using System.Web.Mvc;

namespace Olbrasoft.Travel.Web.Mvc.Controllers
{
    public class UnobtrusiveAjaxController : Controller
    {
		// Unobtrusive Ajax
		public ActionResult Index(int? page)
		{
			var listPaged = GetPagedNames(page); // GetPagedNames is found in BaseController
			if (listPaged == null)
				return HttpNotFound();

			ViewBag.Names = listPaged;
			return Request.IsAjaxRequest()
				? (ActionResult)PartialView("UnobtrusiveAjax_Partial")
				: View();
		}
    }
}
