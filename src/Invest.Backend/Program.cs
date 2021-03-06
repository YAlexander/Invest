﻿using System;
using System.Net;
using System.Threading.Tasks;
using Invest.Backend.Grains.Providers.Storage;
using Microsoft.Extensions.Hosting;
using NLog.Extensions.Logging;
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
				IHost host = new HostBuilder()
					.UseOrleans((context, siloBuilder) =>
					{
						siloBuilder
							.ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory().WithReferences())
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
								services.AddDashboard(options =>
								{
									//options.Username = "USERNAME";
									//options.Password = "PASSWORD";
									options.Host = "*";
									options.Port = 3128;
									options.HostSelf = true;
									options.CounterUpdateIntervalMs = 5000;
								});
								services.AddServicesForSelfHostedDashboard();
								//services.AddSingleton<AppConfig>(configuration);
							})
							.Configure<GrainVersioningOptions>(options =>
							{
								options.DefaultCompatibilityStrategy = nameof(BackwardCompatible);
								options.DefaultVersionSelectorStrategy = nameof(MinimumVersion);
							})
							// TODO: Add IStorageService impl to Storage Provider, move BL into storageService
							.AddGenericGrainStorage<AssetStorageProvider>(nameof(AssetStorageProvider), opt =>
							{
								opt.Configure(options =>
								{
									options.ConnectionString = "";
								});
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
