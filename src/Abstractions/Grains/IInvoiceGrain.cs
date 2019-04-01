using Abstractions.Grains.StateModels;
using Orleans;

namespace Abstractions.Grains
{
	public interface IInvoiceGrain : IGrainWithStringKey
	{
		IInvoiceState Get ();

		IInvoiceState Update(IInvoiceState invoice);
	}
}
