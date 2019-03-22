using System;
using System.Net;
using System.Threading.Tasks;
using Invest.Backend.Grains.Providers.Storage;
using Microsoft.Extensions.Hosting;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;
using Orleans.Versions.Compatibility;
using Orleans.Versions.Selector;

namespace Invest.Backend
{
	class Program
	{
		public static async Task<int> Main (string[] args)
		{
			try
			{
				IHostBuilder host = new HostBuilder()
					.UseOrleans((context, siloBuilder) =>
					{
						siloBuilder
							.Configure<ClusterOptions>(options =>
							{
								options.ClusterId = "InvestorApp";
								options.ServiceId = "Backend";
							})
							.UseAdoNetClustering(options =>
							{
								options.Invariant = "Npgsql";
								options.ConnectionString = "";
							})
							.Configure<EndpointOptions>(options => options.AdvertisedIPAddress = IPAddress.Loopback)
							.ConfigureLogging(logging => logging.AddNLog(new NLogProviderOptions
							{
								CaptureMessageTemplates = true,
								CaptureMessageProperties = true
							}))
							.ConfigureServices(services =>
							{
								services.AddSingleton<AppConfig>(configuration);
							})
							.AddGenericGrainStorage<AssetStorageProvider>(nameof(AssetStorageProvider), opt =>
							{
								opt.Configure(options => { options.ConnectionString = ""; });
							})
							.Configure<GrainVersioningOptions>(options =>
							{
								options.DefaultCompatibilityStrategy = nameof(BackwardCompatible);
								options.DefaultVersionSelectorStrategy = nameof(MinimumVersion);
							})
							.ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory().WithReferences())
							.UseDashboard(options =>
							{
								//options.Username = "USERNAME";
								//options.Password = "PASSWORD";
								options.Host = "*";
								options.Port = 3128;
								options.HostSelf = true;
								options.CounterUpdateIntervalMs = 5000;
							});
					})
					.Build();

				await host.RunAsync();

				return 0;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return 1;
			}
		}
	}
}
