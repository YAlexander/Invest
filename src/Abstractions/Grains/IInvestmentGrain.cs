using System.Threading.Tasks;
using Abstractions.Grains.StateModels;
using Orleans;
using Orleans.CodeGeneration;

namespace Abstractions.Grains
{
	[Version(1)]
	public interface IInvestmentGrain : IGrainWithIntegerKey
	{
		Task<IInvestmentState> Get ();
	}
}
