using Abstractions.Entities;
using Abstractions.Grains;
using Abstractions.Grains.StateModels;
using Invest.Backend.Grains.GrainImplementations.StateModels;
using Invest.Backend.Grains.Providers.Storage;
using Orleans;
using Orleans.Providers;

namespace Invest.Backend.Grains.GrainImplementations
{
	[StorageProvider(ProviderName = nameof(ValuedPaperProvider))]
	public class ValuedPaperGrain : Grain<ValuedPaperState>, IValuedPaperGrain<IValuedPaperState>
	{
		public IValuedPaperState Get ()
		{
			return this.State;
		}
	}
}
