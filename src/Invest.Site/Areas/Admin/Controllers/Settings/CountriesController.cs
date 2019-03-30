using Microsoft.AspNetCore.Mvc;

namespace Invest.Site.Areas.Admin.Controllers.Settings
{
	public class CountriesController : Controller
	{
		public IActionResult Index ()
		{
			return View();
		}
	}
}