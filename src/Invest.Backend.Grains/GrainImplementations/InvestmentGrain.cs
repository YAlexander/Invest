using System.Threading.Tasks;
using Abstractions.Grains;
using Abstractions.Grains.StateModels;
using Invest.Backend.Grains.GrainImplementations.StateModels;
using Orleans;

namespace Invest.Backend.Grains.GrainImplementations
{
	public class InvestmentGrain : Grain<InvestmentState>, IInvestmentGrain
	{
		public Task<IInvestmentState> Get ()
		{
			return Task.FromResult((IInvestmentState)this.State);
		}
	}
}
