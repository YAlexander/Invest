using System;
using System.Threading.Tasks;
using Abstractions.Grains.StateModels;
using Abstractions.Infrastructure;

namespace Invest.Backend.Grains.Services
{
	public abstract class StorageServiceBase<T> : IStorageService<IState>
	{
		public abstract Task Read();

		public abstract Task Write();
	}
}
