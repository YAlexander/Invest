using System.Threading.Tasks;
using Invest.Site.Core.Models;
using Invest.Site.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Invest.Site.Controllers
{
	[Area("Dashboard")]
	public class InvestmentController : Controller
	{
		private readonly InvestmentsService _investmentsService;

		public InvestmentController (InvestmentsService investmentsService)
		{
			this._investmentsService = investmentsService;
		}

		public async Task<IActionResult> Index ()
		{
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Edit (long? id)
		{
			InvestmentDTO model = new InvestmentDTO();

			if (id.HasValue)
			{
				model = await _investmentsService.Get(id.Value);
			}

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit (InvestmentDTO model)
		{
			if (ModelState.IsValid)
			{
				model = await _investmentsService.Get(model.Id);

				return RedirectToAction("Index");
			}

			return View(model);
		}

		public async Task<IActionResult> Details (long id)
		{
			InvestmentDTO model = await _investmentsService.Get(id);
			return View(model);
		}
	}
}
