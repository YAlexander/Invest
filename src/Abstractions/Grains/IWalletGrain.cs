using Abstractions.Entities;
using Abstractions.Grains.StateModels;
using Orleans;

namespace Abstractions.Grains
{
	public interface IWalletGrain : IGrainWithIntegerCompoundKey
	{
		IAccountState Get ();
	}
}
