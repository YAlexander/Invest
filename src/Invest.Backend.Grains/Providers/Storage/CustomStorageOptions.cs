using Abstractions.Grains.StateModels;
using Abstractions.Infrastructure;
using Orleans;

namespace Invest.Backend.Grains.Providers.Storage
{
	public class GenericStorageOptions
	{
		[Redact] public string ConnectionString { get; set; } = string.Empty;

		[Redact] public IStorageService<IState> StorageService { get; set; }
	}
}
