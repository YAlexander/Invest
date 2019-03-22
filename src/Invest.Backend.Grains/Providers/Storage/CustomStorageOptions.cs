using Orleans;

namespace Invest.Backend.Grains.Providers.Storage
{
	public class GenericStorageOptions
	{
		[Redact] public string ConnectionString { get; set; } = string.Empty;
	}
}
