using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Invest.Site.Controllers.Components
{
	public class InfoBlock : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync ()
		{
			return View();
		}
	}
}
