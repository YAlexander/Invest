using System;
using System.Threading.Tasks;
using Orleans;
using Orleans.Providers;
using Orleans.Runtime;
using Orleans.Storage;

namespace Invest.Backend.Grains.Providers.Storage
{
	public class ValuedPaperProvider : IStorageProvider
	{
		public ValuedPaperProvider()
		{
		}

		public Task ReadStateAsync(string grainType, GrainReference grainReference, IGrainState grainState)
		{
			long key = grainReference.GetPrimaryKeyLong();

			throw new NotImplementedException();
		}

		public Task WriteStateAsync(string grainType, GrainReference grainReference, IGrainState grainState)
		{
			throw new NotImplementedException();
		}

		public Task ClearStateAsync(string grainType, GrainReference grainReference, IGrainState grainState)
		{
			return Task.CompletedTask;
		}

		public Task Init(string name, IProviderRuntime providerRuntime, IProviderConfiguration config)
		{
			Name = name;
			return Task.CompletedTask; ;
		}

		public Task Close()
		{
			return Task.CompletedTask; ;
		}

		public string Name { get; set; }
	}
}
