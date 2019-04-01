using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;
using Orleans.Runtime;

namespace Invest.Site.Core
{
	/// <summary>
	/// Orleans cluster client
	/// </summary>
	public class OrleansConnector
	{
		private readonly string _connectionString;
		private IClusterClient _client;

		public IClusterClient Client
		{
			get
			{
				if (!_client.IsInitialized)
				{
					_client = Connect().Result;
				}

				return _client;
			}
		}

		public OrleansConnector(IConfiguration configuration)
		{
			this._connectionString = configuration.GetConnectionString("SystemConnection");
			_client = Connect().Result;
		}

		/// <summary>
		/// Create and configure Orleans client
		/// </summary>
		public async Task<IClusterClient> Connect()
		{
			int attempt = 0;
			while (true)
			{
				try
				{
					_client = new ClientBuilder()
						.UseAdoNetClustering(options =>
						{
							options.Invariant = "Npgsql";
							options.ConnectionString = this._connectionString;
						}).Configure<ClusterOptions>(options =>
						{
							options.ClusterId = "Rialto";
							options.ServiceId = "Backend";
						})
						.AddSimpleMessageStreamProvider("SMSProvider")
						.Build();

					await _client.Connect();
					Console.WriteLine("Client successfully connect to silo host");
					break;
				}
				catch (SiloUnavailableException ex)
				{
					attempt++;
					// TODO: Move max attempts count to config
					Console.WriteLine($"Attempt {attempt} of {5} failed to initialize the Orleans client.");
					if (attempt > 5)
					{
						throw;
					}

					await Task.Delay(TimeSpan.FromSeconds(4));
				}
			}

			return _client;
		}
	}
}
