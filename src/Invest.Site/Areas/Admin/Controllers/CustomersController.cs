using Microsoft.AspNetCore.Mvc;

namespace Invest.Site.Areas.Admin.Controllers
{
	public class CustomersController : Controller
	{
		public IActionResult Index ()
		{
			return View();
		}
	}
}