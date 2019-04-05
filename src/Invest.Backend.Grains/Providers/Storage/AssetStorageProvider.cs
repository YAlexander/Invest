using System;
using System.Threading.Tasks;
using Abstractions.Infrastructure;
using Invest.Backend.Grains.GrainImplementations.StateModels;
using Orleans;
using Orleans.Providers;
using Orleans.Runtime;
using Orleans.Storage;

namespace Invest.Backend.Grains.Providers.Storage
{
	// TODO: Storage provider example
	public class AssetStorageProvider : IStorageProvider
	{

		//private AssetsProcessor assetProcessor;
		private string _connectionString;
		private IStorageService<ValuedPaperState> storageService;

		public AssetStorageProvider(string connectionString, IStorageService<ValuedPaperState> storageService)
		{
			_connectionString = connectionString;
			this.storageService = storageService;
		}

		public Task ReadStateAsync(string grainType, GrainReference grainReference, IGrainState grainState)
		{
			//assetProcessor.Get();
			return Task.CompletedTask;
		}

		public Task WriteStateAsync(string grainType, GrainReference grainReference, IGrainState grainState)
		{
			throw new NotImplementedException();
		}

		public Task ClearStateAsync(string grainType, GrainReference grainReference, IGrainState grainState)
		{
			string key = grainReference.GetPrimaryKeyString();
			return Task.CompletedTask;
		}

		public Task Init(string name, IProviderRuntime providerRuntime, IProviderConfiguration config)
		{
			Name = name;
			return Task.CompletedTask;
		}

		public Task Close()
		{
			return Task.CompletedTask;
		}

		public string Name { get; set; } = string.Empty;
	}
}
