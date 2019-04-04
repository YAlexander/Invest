using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans;
using Orleans.Storage;

namespace Invest.Backend.Grains.Providers.Storage
{
	internal class GenericStorageFactory
	{
		public static IGrainStorage Create<T> (IServiceProvider services, string name) where T : IGrainStorage
		{
			IOptionsSnapshot<GenericStorageOptions> optionsSnapshot = services.GetRequiredService<IOptionsSnapshot<GenericStorageOptions>>();
			GenericStorageOptions options = optionsSnapshot.Get(name);
			T storageManager = ActivatorUtilities.CreateInstance<T>(services);
			object[] args = { storageManager, options.ConnectionString ?? string.Empty, services };
			return ActivatorUtilities.CreateInstance<T>(services, args);
		}
	}
}
