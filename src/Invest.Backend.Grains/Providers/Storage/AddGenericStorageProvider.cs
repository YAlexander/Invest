
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;
using Orleans.Runtime;
using Orleans.Storage;

namespace Invest.Backend.Grains.Providers.Storage
{
	public static class AddGenericStorageProvider
	{
		public static ISiloBuilder AddGenericGrainStorage<T> (this ISiloBuilder builder, string name, Action<OptionsBuilder<GenericStorageOptions>> options) where T : IGrainStorage
		{
			return builder.ConfigureServices(services =>
			{
				options.Invoke(services.AddOptions<GenericStorageOptions>(name));
				services.ConfigureNamedOptionForLogging<GenericStorageOptions>(name);
				services.TryAddSingleton<IGrainStorage>(sp => sp.GetServiceByName<IGrainStorage>(nameof(T)));
				services.AddSingletonNamedService<IGrainStorage>(name, GenericStorageFactory.Create<T>);
			});
		}
	}
}
