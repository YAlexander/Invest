using System;
using System.Threading.Tasks;
using Invest.Backend.Grains.GrainImplementations.StateModels;

namespace Invest.Backend.Grains.Services
{
	public class AssetService : StorageServiceBase<ValuedPaperState>
	{
		public AssetService(IServiceProvider provider)
		{

		}


		public override Task Read()
		{
			throw new NotImplementedException();
		}

		public override Task Write()
		{
			throw new NotImplementedException();
		}
	}
}
