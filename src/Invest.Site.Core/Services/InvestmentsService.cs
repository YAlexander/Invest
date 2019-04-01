using System.Threading.Tasks;
using Abstractions.Grains;
using Abstractions.Grains.StateModels;
using Invest.Site.Core.Helpers.Mappers;
using Invest.Site.Core.Models;
using Orleans;

namespace Invest.Site.Core.Services
{
	public class InvestmentsService
	{
		private readonly IClusterClient _client;

		public InvestmentsService(OrleansConnector orleansContext)
		{
			this._client = orleansContext.Client;
		}

		public async Task<InvestmentDTO> Get(long id)
		{
			IInvestmentGrain grain = _client.GetGrain<IInvestmentGrain>(id);
			IInvestmentState investment = await grain.Get();
			InvestmentDTO model = investment.ToModel();
			return model;
		}
	}
}
