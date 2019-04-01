using Abstractions.Codes;
using Abstractions.Grains.StateModels;
using Orleans;

namespace Abstractions.Grains
{
	public interface ITransactionGrain : IGrainWithStringKey
	{
		ITransactionState Get ();

		string Create (ITransactionState transaction);

		bool Update (ITransactionStatusCode status);
	}
}
