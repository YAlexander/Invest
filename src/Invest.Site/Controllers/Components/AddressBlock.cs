using Microsoft.AspNetCore.Mvc;

namespace Invest.Site.Controllers.Components
{
	public class AddressBlock : ViewComponent
	{
		public IViewComponentResult Invoke ()
		{
			return View();
		}
	}
}
