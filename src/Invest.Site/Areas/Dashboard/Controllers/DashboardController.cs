using Microsoft.AspNetCore.Mvc;

namespace Invest.Site.Areas.Dashboard.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index ()
		{
			return View();
		}
	}
}